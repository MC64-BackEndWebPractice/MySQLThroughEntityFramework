using System.ComponentModel.DataAnnotations;

namespace MySQLThroughEntityFramework.Models
{
    /// <summary>
    /// Blog category data object. Represents an entity in the database.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Key value for storage.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Must not be null or empty when modifiying database state.
        /// Value must be 2-100 characters in length.
        /// </summary>
        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Sorting value for display of this Category.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Defaults to the date it was created at.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
