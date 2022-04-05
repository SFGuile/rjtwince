using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace rjtquery
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int getindenty(string usr, string pass);

        [OperationContract]
        QueryRsult[] getquery(QueryArgs qargs, int pageSize, int pageIndex, out int pageCount, out int Counts, string usr, string pass);

        // 任务: 在此处添加服务操作
    }

    // 使用下面示例中说明的数据协定将复合类型添加到服务操作

    [DataContract]
    public class QueryArgs
    {



        [DataMember]
        public string prodno
        {
            get;
            set;
        }

        [DataMember]
        public string prodname
        {
            get;
            set;
        }
        [DataMember]
        public string batchno
        {
            get;
            set;
        }

        [DataMember]
        public string barcode
        {
            get;
            set;
        }


    }



    [DataContract]
    public struct QueryRsult
    {



        [DataMember]
        public string prodno
        {
            get;
            set;
        }

        [DataMember]
        public string prodname
        {
            get;
            set;
        }
        [DataMember]
        public string prodsize
        {
            get;
            set;
        }
        [DataMember]
        public string monad
        {
            get;
            set;
        }
        [DataMember]
        public string batchno
        {
            get;
            set;
        }
        [DataMember]
        public string batchnozj
        {
            get;
            set;
        }
        [DataMember]
        public string prodpzwh
        {
            get;
            set;
        }
        [DataMember]
        public string floorno
        {
            get;
            set;
        }
        [DataMember]
        public string wareno
        {
            get;
            set;
        }
        [DataMember]
        public double lestnum
        {
            get;
            set;
        }
        [DataMember]
        public double lestnumzj
        {
            get;
            set;
        }

        [DataMember]
        public string deppos
        {
            get;
            set;
        }

        [DataMember]
        public string permemo
        {
            get;
            set;
        }
    }

    
    

 
    [DataContract]
    public class GetDataFault
    {

        private string operation;
        private string problemType;

        [DataMember]
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        [DataMember]
        public string ProblemType
        {
            get { return problemType; }
            set { problemType = value; }
        }

    }
}
