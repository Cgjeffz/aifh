﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIFH_Vol2.Core.Learning
{
    /// <summary>
    /// A classification algorithm is used to classify input data into classes.
    /// </summary>
    public interface IClassificationAlgorithm: IMLMethod
    {
        /// <summary>
        /// Classify the specified input into a group.
        /// </summary>
        /// <param name="input">The input data.</param>
        /// <returns>The group the data was classified into.</returns>
        public int ComputeClassification(double[] input);
    }
}