using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice
{
    class ImagePost:Post
    {
        public string imageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.id = GetNextId();
            this.title = title;
            this.sendByUserName = sendByUserName;
            this.isPublic = isPublic;

            this.imageURL = imageURL;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - by {3}", this.id, this.title, this.imageURL, this.sendByUserName);
        }
    }
}
