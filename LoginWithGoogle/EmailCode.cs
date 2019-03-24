using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWithGoogle.App_Code
{
  
        public class GoogleProfile {

            public string ID { get; set; }
            public string DisplayName { get; set; }
            public string Sexo { get; set; }
            public string ObjectyType { get; set; }
            public Image Image { get; set; }
            public List<Email> Emails { get; set; }

        }
        public class Email {
            public string Value{ get; set; }
            public string Type { get; set; }

        }
        public class Image {
            public string Url { get; set; }
        }
    }
