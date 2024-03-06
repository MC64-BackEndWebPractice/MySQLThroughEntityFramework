using Microsoft.EntityFrameworkCore;
using MySQLThroughEntityFramework.Models;

namespace MySQLThroughEntityFramework.Data
{
    /// <summary>
    ///   The database context for the entire app.<para/>
    ///   <inheritdoc/>
    /// </summary>
    /// <inheritdoc/>
    public class ApplicationDbContext:DbContext
    {
        /// <summary>
        /// Passes along the modified options for running the DbContext.
        /// </summary>
        /// <param name="options">mainly supplies the connection string for the db</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        /// <summary>
        /// The table representing the categories that blog posts can be associated with.
        /// </summary>
        public DbSet<Category> Categories { get; set; }
    }
}
