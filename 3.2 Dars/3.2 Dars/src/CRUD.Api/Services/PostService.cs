using CRUD.Api.Dtos;
using CRUD.Api.Entities;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CRUD.Api.Services
{
    public class PostService : IPostService
    {

        private List<Post> posts;

        private readonly string FilePath;
        public PostService()
        {

            FilePath = "C:\\Users\\yoldo\\OneDrive\\Desktop\\Coding\\DotNet\\ModulBir\\BirinchiModul\\3.2 Dars\\3.2 Dars\\src\\CRUD.Api\\AppDBContext\\DataJson.txt";
            posts = new List<Post>();

        }

        public Guid CreatePost(PostCreateDto postCreateDto)
        {

            ReadPostsFromFile();

            Post post = new Post()
            {
                PostId = Guid.NewGuid(),
                Title = postCreateDto.Title,
                Content = postCreateDto.Content,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                UserId = postCreateDto.UserId
            };

            posts.Add(post);
            SavePostsToFile();
            return post.PostId;
        }

        public bool DeletePost(Guid postId)
        {

            ReadPostsFromFile();

            foreach (var post in posts)
            {
                if (post.PostId == postId)
                {
                    posts.Remove(post);
                    SavePostsToFile();
                    return true;
                }

            }
            return false;
        }

        public List<PostGetDto> GetAllPosts()
        {

            ReadPostsFromFile();

            List<PostGetDto> postGetDtos = new List<PostGetDto>();
            foreach (var p in posts)
            {
                postGetDtos.Add(new PostGetDto()
                {

                    PostId = p.PostId,
                    Title = p.Title,
                    Content = p.Content,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    UserId = p.UserId

                });

            }

            return postGetDtos;

        }

        public PostGetDto? GetPostById(Guid postId)
        {

            ReadPostsFromFile();

            foreach (var p in posts)
            {

                if (p.PostId == postId)
                {

                    return new PostGetDto()
                    {

                        PostId = p.PostId,
                        Title = p.Title,
                        Content = p.Content,
                        CreatedAt = p.CreatedAt,
                        UpdatedAt = p.UpdatedAt,
                        UserId = p.UserId

                    };

                }

            }

            return null;

        }

        public bool UpdatePost(Guid postId, PostUpdateDto postUpdateDto)
        {
            ReadPostsFromFile();

            foreach (var p in posts)
            {

                if (p.PostId == postId)
                {

                    p.PostId = postId;
                    p.Title = postUpdateDto.Title;
                    p.Content = postUpdateDto.Content;
                    p.CreatedAt = DateTime.UtcNow;
                    p.UpdatedAt = DateTime.UtcNow;

                }

            }

            return true;

        }



        private void SavePostsToFile()
        {

            var json = JsonSerializer.Serialize(posts);
            File.WriteAllText(FilePath, json);

        }


        private void ReadPostsFromFile()
        {

            var json = File.ReadAllText(FilePath);

            if (string.IsNullOrEmpty(json))
            {
                posts = new List<Post>();
                return;
            }

            posts = JsonSerializer.Deserialize<List<Post>>(json);

        }

    }
}