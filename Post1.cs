using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Post1
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeDateCreated { get; private set; }
        public int VoteCount { get; private set; }
        private bool HasVotedUp;
        private bool HasVotedDown;

        public Post1(string title, string description)
        {
            Title = title;
            Description = description;
            TimeDateCreated = DateTime.UtcNow;
            VoteCount = 0;
        }

        public void VoteUp()
        {
            if (HasVotedUp)
            {
                throw new Exception("You have already up-voted.");
            }
            else
            {
                VoteCount++;
                HasVotedUp = true;
                HasVotedDown = false;
            }
        }

        public void VoteDown()
        {
            if (HasVotedDown)
            {
                throw new Exception("You have already down-voted.");
            }
            else
            {
                VoteCount--;
                HasVotedDown = true;
                HasVotedUp = false;
            }
        }
    }
}
