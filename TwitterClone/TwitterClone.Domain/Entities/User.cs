
using System;
using System.Collections.Generic;

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstname;
        private string _lastname;
        private string _email;

        public User()
        {
            _id = Guid.NewGuid();

            Following = new List<Follow>();
            Followers = new List<Follow>();
            Notifications = new List<Notification>();
            SentMessages = new List<Message>();
            ReceivedMessages = new List<Message>();
            Bookmarks = new List<Bookmark>();
            Retweets = new List<Retweet>();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Follow and Followers
        public List<Follow> Following { get; private set; }
        public List<Follow> Followers { get; private set; }

        // Notifications
        public List<Notification> Notifications { get; private set; }

        // Messages
        public List<Message> SentMessages { get; private set; }
        public List<Message> ReceivedMessages { get; private set; }

        // Bookmarks
        public List<Bookmark> Bookmarks { get; private set; }

        // Retweets
        public List<Retweet> Retweets { get; private set; }
    }
}
