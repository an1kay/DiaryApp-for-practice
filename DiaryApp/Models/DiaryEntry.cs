using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        
        public int Id { get; set; }
        [Required] public string Title { get; set; } = string.Empty;
        [Required] public string Content { get; set; } = string.Empty;

        [Required] public DateTime Created { get; set; } = DateTime.Now;
        [AllowNull] public List<string> Tags { get; set; } = new List<string>();
    }
}
