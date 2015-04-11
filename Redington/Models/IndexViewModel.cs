using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Redington.Models
{
    /// <summary>
    /// IndexViewModel
    /// </summary>
    [Serializable]
    public class IndexViewModel
    {
        /// <summary>
        /// Gets or sets the probability one.
        /// </summary>
        /// <value>
        /// The probability one.
        /// </value>
        [Required(ErrorMessage = "Required")]
        [Range(0f, 1f, ErrorMessage = "Probability must be between 0.0 and 1.0")]
        public decimal ProbabilityOne { get; set; }

        /// <summary>
        /// Gets or sets the probability two.
        /// </summary>
        /// <value>
        /// The probability two.
        /// </value>
        [Required(ErrorMessage = "Required")]
        [Range(0f, 1f, ErrorMessage = "Probability must be between 0.0 and 1.0")]
        public decimal ProbabilityTwo { get; set; }

        /// <summary>
        /// Gets or sets the selected option.
        /// </summary>
        /// <value>
        /// The selected option.
        /// </value>
        [Required]
        public string SelectedOption { get; set; }
    }
}