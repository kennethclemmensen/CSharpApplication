using System.ComponentModel.DataAnnotations;

namespace Entity {

    /// <summary>
    /// The Word class contains properties for a word
    /// </summary>
    public class Word {

        /// <summary>
        /// Get or set the ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or set the term
        /// </summary>
        [Required]
        public string Term { get; set; }

        /// <summary>
        /// Get or set the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or set the user ID
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Get or set the user
        /// </summary>
        public virtual User User { get; set; }
    }
}