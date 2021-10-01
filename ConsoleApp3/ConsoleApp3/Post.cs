using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class Post
   {
        public string Text;
        public string SharedDate;
        public string LikeCount;
        public string CommentCount;
        public string Comment[] Comments;

        public Post(string text)
        {
            this.Text = text;
        }
    }
}
