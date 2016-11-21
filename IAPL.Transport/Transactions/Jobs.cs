/******************************************************
 * 
 *  Author          : Mark Daniel N. Torres
 *  Date Created    : 09/16/2016
 *
 *  Description     : Contains all classes, properties, and methods used in serialization.
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IAPL.Transport.Transactions
{
    public class GPP
    {
        [XmlElement(ElementName = "Jobs")]
        public Jobs Job { get; set; }
    }

    public class Jobs
    {
        public ABCD ABCD { get; set; }
        public EFGH EFGH { get; set; }
        public IJKL IJKL { get; set; }
        public MNOP MNOP { get; set; }
        public QRST QRST { get; set; }
        public UVWX UVWX { get; set; }
        public YZ09 YZ09 { get; set; }
    }   

    public class MainAlpha
    {
        public List<Trigger> Triggers { get; set; }
    }

    public class ABCD : MainAlpha { }
    public class EFGH : MainAlpha { }
    public class IJKL : MainAlpha { }
    public class MNOP : MainAlpha { }
    public class QRST : MainAlpha { }
    public class UVWX : MainAlpha { }
    public class YZ09 : MainAlpha { }

    public class Trigger
    {
        private string _triggerName;
        private string _principalCode;
        private string _erp;
        private string _messageCode;

        public string TriggerName
        {
            get { return _triggerName; }
            set { _triggerName = CleanString(value); }
        }

        public string PrincipalCode
        {
            get { return _principalCode; }
            set { _principalCode = CleanString(value); }
        }

        public string ERP
        {
            get { return _erp; }
            set { _erp = CleanString(value); }
        }

        public string MessageCode
        {
            get { return _messageCode; }
            set { _messageCode = CleanString(value); }
        }

        private string CleanString(string value)
        {
            return (value ?? string.Empty).Trim().ToUpper();
        }

        public int MsgMonday { get; set; }
        public int MsgTuesday { get; set; }
        public int MsgWednesday { get; set; }
        public int MsgThursday { get; set; }
        public int MsgFriday { get; set; }
        public int MsgSaturday { get; set; }
        public int MsgSunday { get; set; }
        public int MsetRunTime { get; set; }
        public DateTime MsetStartTime { get; set; }
        public DateTime MsetEndTime { get; set; }
        public string JobCronSchedule { get; set; }
        public int RepeatForever { get; set; }
        public int StartNow { get; set; }



    }
}
