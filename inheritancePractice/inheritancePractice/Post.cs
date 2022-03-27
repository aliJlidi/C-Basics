using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice
{
    class Post
    {
        private static int currentPostId;
        //properties
        protected int id { get; set; }
        protected string title { get; set; }
        protected string sendByUserName { get; set; }
        protected bool isPublic { get; set; }


        public Post()
        {
            id = 0;
            title = "My first post";
            isPublic = true;
            sendByUserName = "ali Jlidi";
        }
        //Instance with parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.id = GetNextId();
            this.title = title;
            this.sendByUserName = sendByUserName;
            this.isPublic = isPublic; 
        }
        protected int GetNextId()
        {
            return ++currentPostId; 
        }
        public void Update(string title, bool isPublic)
        {
            this.title = title;
            this.isPublic = isPublic; 
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.id, this.title, this.sendByUserName);
        }
    }
}
