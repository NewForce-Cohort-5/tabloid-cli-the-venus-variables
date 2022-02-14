﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabloidCLI.Models;
using TabloidCLI.Repositories;


namespace TabloidCLI.UserInterfaceManagers
{
    internal class PostDetailManager: IUserInterfaceManager
    {
        private IUserInterfaceManager _parentUI;
        private PostRepository _postRepository;
        private AuthorRepository _authorRepository;
        private TagRepository _tagRepository;
        private int _postId;

        public PostDetailManager(IUserInterfaceManager parentUI, string connectionString, int postId)
        {
            _parentUI = parentUI;
            _authorRepository = new AuthorRepository(connectionString);
            _postRepository = new PostRepository(connectionString);
            _tagRepository = new TagRepository(connectionString);
            _postId = postId;
        }

        public IUserInterfaceManager Execute()
        {
            Post post = _postRepository.Get(_postId);
            Console.WriteLine($"{post.Title} Details");
            Console.WriteLine(" 1) View");
            Console.WriteLine(" 2) View Posts");
            //Console.WriteLine(" 3) Add Tag");
            //Console.WriteLine(" 4) Remove Tag");
            Console.WriteLine(" 0) Go Back");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    View();
                    return this;
                case "2":
                    ViewPosts();
                    return this;
                //case "3":
                //    AddTag();
                //    return this;
                //case "4":
                //     RemoveTag();
                //    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }

        private void View()
        {
            Post post = _postRepository.Get(_postId);
            Console.WriteLine($"Name: {post.Title}");
            Console.WriteLine($"Bio: {post.Url}");
            Console.WriteLine("Tags:");
            //foreach (Tag tag in post.Tags)
            //{
            //    Console.WriteLine(" " + tag);
            //}
            Console.WriteLine();
        }

        private void ViewPosts()
        {
            List<Post> posts = _postRepository.GetByAuthor(_postId);
            foreach (Post post in posts)
            {
                Console.WriteLine(post);
            }
            Console.WriteLine();
        }


        private void AddTag()
        {
            throw new NotImplementedException();
            //Post post = _postRepository.Get(_postId);

            //Console.WriteLine($"Which tag would you like to add to {post.Title}?");
            //List<Tag> tags = _tagRepository.GetAll();

            //for (int i = 0; i < tags.Count; i++)
            //{
            //    Tag tag = tags[i];
            //    Console.WriteLine($" {i + 1}) {tag.Name}");
            //}
            //Console.Write("> ");

            //string input = Console.ReadLine();
            //try
            //{
            //    int choice = int.Parse(input);
            //    Tag tag = tags[choice - 1];
            //    _authorRepository.InsertTag(author, tag);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid Selection. Won't add any tags.");
            //}
        }

        private void RemoveTag()
        {
            throw new NotImplementedException();
            //Post post = _postRepository.Get(_postId);

            //Console.WriteLine($"Which tag would you like to remove from {post.}?");
            //List<Tag> tags = author.Tags;

            //for (int i = 0; i < tags.Count; i++)
            //{
            //    Tag tag = tags[i];
            //    Console.WriteLine($" {i + 1}) {tag.Name}");
            //}
            //Console.Write("> ");

            //string input = Console.ReadLine();
            //try
            //{
            //    int choice = int.Parse(input);
            //    Tag tag = tags[choice - 1];
            //    _authorRepository.DeleteTag(author.Id, tag.Id);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid Selection. Won't remove any tags.");
            //}
        }
    }
}
