using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BLib.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public static byte Unknown { get; internal set; }
        public static byte PayAsYouGo { get; internal set; }
    }
}