using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGridPreview.Models
{
    public class Info
    {
        public DateTime DateTime { get; set; }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Oid Oid { get; set; } = new Oid();
        public Rectangle Rectangle { get; set; } = new Rectangle();
        public Uri Uri { get; set; }
    }
}
