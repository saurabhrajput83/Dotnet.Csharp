using System;
using System.Collections.Generic;

namespace SOLID
{

    public interface IPost
    {
        void CreatePost(string message);
        void ReadAllPosts();
    }

    /// <summary>
    /// Interface segregation principle
    /// </summary>
    public interface IPostCreate
    {
        void CreatePost(string message);
    }

    /// <summary>
    /// Interface segregation principle
    /// </summary>
    public interface IPostRead
    {
        void ReadAllPosts();
    }

    /// <summary>
    /// class Database
    /// </summary>
    public class Database
    {
        private List<string> _messages;

        public Database()
        {
            _messages = new List<string>();
        }

        public void AddPost(string postMessage)
        {
            _messages.Add(postMessage);
            Console.WriteLine("AddPost: " + postMessage);
        }

        public void AddTagPost(string postMessage)
        {
            _messages.Add(postMessage);
            Console.WriteLine("AddTagPost: " + postMessage);
        }

        public void AddMentionPost(string postMessage)
        {
            _messages.Add(postMessage);
            Console.WriteLine("AddMentionPost: " + postMessage);
        }
    }

    /// <summary>
    /// class ErrorLogger
    /// </summary>
    public class ErrorLogger
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine("LogError: " + ex.Message);
        }
    }

    /// <summary>
    /// SingleResponsibilityPrinciple
    /// </summary>
    public class Post : IPostCreate, IPostRead
    {
        private readonly Database _objDatabase;
        private readonly ErrorLogger _objErrorLogger;

        public Post(Database objDatabase, ErrorLogger objErrorLogger)
        {
            _objDatabase = objDatabase;
            _objErrorLogger = objErrorLogger;
        }

        public virtual void CreatePost(string postMessage)
        {
            try
            {
                _objDatabase.AddPost(postMessage);
            }
            catch (Exception ex)
            {
                _objErrorLogger.LogError(ex);
            }
        }
        public void ReadAllPosts()
        {
            
        }
    }

    /// <summary>
    /// Open/closed principle
    /// </summary>
    public class TagPost : Post
    {
        private readonly Database _objDatabase;
        private readonly ErrorLogger _objErrorLogger;

        public TagPost(Database objDatabase, ErrorLogger objErrorLogger)
            : base(objDatabase, objErrorLogger)
        {
            _objDatabase = objDatabase;
            _objErrorLogger = objErrorLogger;
        }

        public override void CreatePost(string postMessage)
        {
            _objDatabase.AddTagPost(postMessage);
        }
    }

    public class MentionPost : Post
    {
        private readonly Database _objDatabase;
        private readonly ErrorLogger _objErrorLogger;

        public MentionPost(Database objDatabase, ErrorLogger objErrorLogger)
            : base(objDatabase, objErrorLogger)
        {
            _objDatabase = objDatabase;
            _objErrorLogger = objErrorLogger;
        }

        public override void CreatePost(string postMessage)
        {
            _objDatabase.AddMentionPost(postMessage);
        }
    }

    public class PostHandler
    {
        private readonly Database _objDatabase;
        private readonly ErrorLogger _objErrorLogger;
        Post _post;

        public PostHandler()
        {
            _objDatabase = new Database();
            _objErrorLogger = new ErrorLogger();
        }

        public void CreatePost(string postMessage)
        {
            if (postMessage.StartsWith("@"))
            {
                _post = new MentionPost(_objDatabase, _objErrorLogger);
            }
            else if (postMessage.StartsWith("#"))
            {
                _post = new TagPost(_objDatabase, _objErrorLogger);
            }
            else
            {
                _post = new Post(_objDatabase, _objErrorLogger);
            }

            _post.CreatePost(postMessage);
        }
    }
}
