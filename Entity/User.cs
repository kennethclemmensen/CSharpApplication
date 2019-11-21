using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity {

    /// <summary>
    /// The User class contains properties for an user
    /// </summary>
    public class User {

        /// <summary>
        /// Get or set the ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or set the username
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Get or set the password
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Get or set the words
        /// </summary>
        public virtual List<Word> Words { get; set; }
    }
}