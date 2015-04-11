using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Redington.Models
{
    [Serializable]
    public class Calculation
    {
        /// <summary>
        /// Gets or sets the probability one.
        /// </summary>
        /// <value>
        /// The probability one.
        /// </value>
        public decimal ProbabilityOne { get; set; }

        /// <summary>
        /// Gets or sets the probability two.
        /// </summary>
        /// <value>
        /// The probability two.
        /// </value>
        public decimal ProbabilityTwo { get; set; }

        /// <summary>
        /// Gets or sets the selected option.
        /// </summary>
        /// <value>
        /// The selected option.
        /// </value>
        public string SelectedOption { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public decimal Result { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime { get; set; }

        public Calculation()
        {
            this.Guid = Guid.NewGuid();
            this.DateTime = DateTime.Now;
        }
    }
}