using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Collections.Specialized;


namespace rjtquery
{
    // 注意: 如果更改此处的类名“IService1”，也必须更新 App.config 中对“IService1”的引用。
    public class Service1 : IService1
    {
        public int getindenty(string usr, string pass)
        {

            if (string.IsNullOrEmpty(usr))
                return -2;
            if (string.IsNullOrEmpty(pass))
                return -3;

            string connstr = @"server =.;database=rjt;uid=sa;pwd=''";
            pass=getMd5Hash(pass);
            rjtDataClassesDataContext db = new rjtDataClassesDataContext(connstr);
            {
                var query = (from c in db.ce_word
                             where c.user_name == usr && c.user_pass == pass
                             select c);
                int theresultcount = query.Count();
                if (theresultcount == 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            
        }

        public QueryRsult[] getquery(QueryArgs qargs, int pageSize, int pageIndex, out int pageCount, out int Counts, string usr, string pass)
        {
            int identresult = getindenty(usr, pass);
            if (identresult < 0)
                throw new Exception("错误验证");

            string connstr = @"server =.;database=rjt;uid=sa;pwd=''";

            QueryRsult[] qrc = new QueryRsult[pageSize];

            try
            {
                

                rjtDataClassesDataContext db = new rjtDataClassesDataContext(connstr);
                {

                    /*from c in Products 
                              join e in Prod_deps on c.Prod_no equals e.Prod_no into group1
                              from g1 in group1.DefaultIfEmpty()
                              join f in Prod_dep_zjcs on c.Prod_no equals f.Prod_no into group2
                              from g2 in group2.DefaultIfEmpty()
                              join g in Ware_Houses on c.Ware_no equals g.Ware_No into group3
                              from g3 in group3.DefaultIfEmpty()
                              select new{ c.Prod_no ,c.Prod_name ,c.Prod_size ,c.Bar_code ,c.Monad ,g1.Batch_no,g1.Lest_num,batchnozj=g2.Batch_no ,lestnumzj=g2.Lest_num,c.Prod_pzwh,c.Ware_no ,c.Dep_pos ,c.Per_memo ,g3.Floor_No  }*/


                    var query = (db.product 
   .GroupJoin(
      db.prod_dep ,
      c => c.prod_no,
      e => e.prod_no,
      (c, group1) =>
         new
         {
             c = c,
             group1 = group1
         }
   )
   .SelectMany(
      temp0 => temp0.group1.DefaultIfEmpty(),
      (temp0, g1) =>
         new
         {
             temp0 = temp0,
             g1 = g1
         }
   )
   .GroupJoin(
      db.prod_dep_zjc,
      temp1 => temp1.temp0.c.prod_no,
      f => f.prod_no,
      (temp1, group2) =>
         new
         {
             temp1 = temp1,
             group2 = group2
         }
   )
   .SelectMany(
      temp2 => temp2.group2.DefaultIfEmpty(),
      (temp2, g2) =>
         new
         {
             temp2 = temp2,
             g2 = g2
         }
   )
   .GroupJoin(
      db.Ware_House,
      temp3 => temp3.temp2.temp1.temp0.c.ware_no,
      g => g.Ware_No,
      (temp3, group3) =>
         new
         {
             temp3 = temp3,
             group3 = group3
         }
   )
   .SelectMany(
      temp4 => temp4.group3.DefaultIfEmpty(),
      (temp4, g3) =>
         new
         {
             Prod_no = temp4.temp3.temp2.temp1.temp0.c.prod_no,
             Prod_name = temp4.temp3.temp2.temp1.temp0.c.prod_name,
             Prod_size = temp4.temp3.temp2.temp1.temp0.c.prod_size,
             Bar_code = temp4.temp3.temp2.temp1.temp0.c.bar_code,
             Monad = temp4.temp3.temp2.temp1.temp0.c.monad,
             Prod_pzwh = temp4.temp3.temp2.temp1.temp0.c.prod_pzwh,
             Ware_no = temp4.temp3.temp2.temp1.temp0.c.ware_no,
             Dep_pos = temp4.temp3.temp2.temp1.temp0.c.dep_pos,
             Per_memo = temp4.temp3.temp2.temp1.temp0.c.per_memo,
             batchno = temp4.temp3.temp2.temp1.g1.batch_no,
             lestnum = (Decimal?)temp4.temp3.temp2.temp1.g1.lest_num ?? 0,
             batchnozj = temp4.temp3.g2.batch_no,
             lestnumzj = (Decimal?)temp4.temp3.g2.lest_num ?? 0,
             Floor_No = g3.Floor_No
         }
   )

);

                  


                    var objQueryWhere = PredicateBuilder.True(query);

                    if (!string.IsNullOrEmpty(qargs.prodno))
                    {
                        objQueryWhere = objQueryWhere.And(c => c.Prod_no.Contains(qargs.prodno));
                    }
                    if (!string.IsNullOrEmpty(qargs.prodname))
                    {

                        objQueryWhere = objQueryWhere.And(c => c.Prod_name.Contains(qargs.prodname));
                    }
                    if (!string.IsNullOrEmpty(qargs.batchno ))
                    {
                        objQueryWhere = objQueryWhere.And(c => c.batchno.Contains(qargs.batchno ));
                    }
                    if (!string.IsNullOrEmpty(qargs.barcode))
                    {
                        objQueryWhere = objQueryWhere.And(c => c.Bar_code.Contains(qargs.barcode));
                    }

                    query=query.OrderBy(c=>c.Prod_no).Where(objQueryWhere);

                    Counts = query.Count();

                    if (Counts % pageSize != 0)
                    {
                        pageCount = Counts / pageSize + 1;
                    }
                    else
                    {
                        pageCount = Counts / pageSize;
                    }

                    var resultPagging = query.ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize);

                    int j=0;

                    foreach (var q in resultPagging)
                    {
                        
                            qrc[j].prodno = q.Prod_no;
                            qrc[j].prodname = q.Prod_name;
                            qrc[j].batchno = q.batchno ;
                            qrc[j].prodpzwh = q.Prod_pzwh;
                            qrc[j].prodsize = q.Prod_size;
                            qrc[j].wareno = q.Ware_no;
                            qrc[j].lestnum = Convert.ToDouble(q.lestnum);
                            qrc[j].monad = q.Monad;
                            qrc[j].floorno = q.Floor_No;
                            qrc[j].deppos = q.Dep_pos;
                            qrc[j].permemo = q.Per_memo;
                            qrc[j].batchnozj = q.batchnozj;
                            qrc[j].lestnumzj = Convert.ToDouble(q.lestnumzj);
                            j++;

                       

                    }

                    return qrc;

                }
                
            }
            catch (Exception ex)
            {
                GetDataFault gcif = new GetDataFault();
                gcif.Operation = " 在查询数据库记录时发生异常";
                gcif.ProblemType = "错误发生：" + ex.ToString();
                string expmessag = ex.ToString();
                if (expmessag.Length > 900)
                    expmessag = ex.ToString().Substring(0, 900);
               
                throw new FaultException<GetDataFault>(gcif, expmessag);

            }
           
            
          

        }

       
       

       public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


    }
}
