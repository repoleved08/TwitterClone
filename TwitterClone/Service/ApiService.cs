using System.Net.Http.Json;
using TwitterClone.Models;

namespace TwitterClone.Service
{
    public class ApiService
    {
        private readonly HttpClient _http;

        public ApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _http.GetFromJsonAsync<IEnumerable<User>>("https://jsonplaceholder.typicode.com/users");
        }

        public async Task<IEnumerable<Post>> GetPostsAsync(int userId)
        {
            return await _http.GetFromJsonAsync<IEnumerable<Post>>($"https://jsonplaceholder.typicode.com/posts?userId={userId}");
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync(int postId)
        {
            return await _http.GetFromJsonAsync<IEnumerable<Comment>>($"https://jsonplaceholder.typicode.com/comments?postId={postId}");
        }
    }

}
