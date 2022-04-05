using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace rjtce
{
    class globalvar
    {
        static string _un;
        static string _pwd;
        static int _errcount;
        static Int32 _recount;
        static Int32 _pagecount;
        static string _prodnoq;
        static string _prodnameq;
        static string _batchnoq;
        static string _barcodeq;

        public static string un
        {

            get
            {
                return _un;
            }
            set
            {
                _un = value;
            }
        }

        public static string pwd
        {

            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
            }
        }

        public static int errcount
        {

            get
            {
                return _errcount;
            }
            set
            {
                _errcount = value;
            }
        }

        public static Int32  recount
        {

            get
            {
                return _recount;
            }
            set
            {
                _recount = value;
            }
        }

        public static Int32 pagecount
        {

            get
            {
                return _pagecount;
            }
            set
            {
                _pagecount = value;
            }
        }

        public static string prodnoq
        {

            get
            {
                return _prodnoq;
            }
            set
            {
                _prodnoq = value;
            }
        }


        public static string prodnameq
        {

            get
            {
                return _prodnameq;
            }
            set
            {
                _prodnameq = value;
            }
        }


        public static string batchnoq
        {

            get
            {
                return _batchnoq;
            }
            set
            {
                _batchnoq = value;
            }
        }

        public static string barcodeq
        {

            get
            {
                return _barcodeq;
            }
            set
            {
                _barcodeq = value;
            }
        }

    }
}
