// <copyright file="MethodResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HIRCASA.MX.CORE.LIB.DOMAIN.Common
{
    /// <summary>
    /// Standar method response class.
    /// </summary>
    /// <typeparam name="T"> T Class.</typeparam>
    public class MethodResponse<T>
    {
        /// <summary>
        /// Gets or Sets REsponse Code.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets response Message.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or Sets Result.
        /// </summary>
        public T? Result { get; set; }
    }
}
