﻿using System;
using System.Text.RegularExpressions;

namespace Commons
{
	public static class StringExtensions
	{
		/// <summary>
		/// Determines whether the <paramref name="source"/> matches the regular-expression <paramref name="pattern"/>.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be determined.</param>
		/// <param name="pattern">The regular-expression.</param>
		/// <returns><c>true</c> means match, <c>false</c> otherwise.</returns>
		public static Boolean IsMatch(this String source, String pattern)
		{
			return Regex.IsMatch(source, pattern);
		}

		/// <summary>
		/// Replaces <paramref name="source"/> with <paramref name="replacement"/> by regular-expression <paramref name="pattern"/>.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be replaced.</param>
		/// <param name="pattern">The regular-expression pattern.</param>
		/// <param name="replacement">The regular-expression replacement.</param>
		/// <returns>The replaced string.</returns>
		public static String RegexReplace(this String source, String pattern, String replacement)
		{
			return Regex.Replace(source, pattern, replacement);
		}

		/// <summary>
		/// Determines whether the <paramref name="source"/> is null or empty string.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be determined.</param>
		/// <returns><c>true</c> means string is null or empty, <c>false</c> otherwise.</returns>
		public static Boolean IsEmpty(this String source)
		{
			return String.IsNullOrEmpty(source);
		}

		/// <summary>
		/// Determines whether the <paramref name="source"/> is neither null nor empty string.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be determined.</param>
		/// <returns><c>true</c> means string is neither null nor empty, <c>false</c> otherwise.</returns>
		public static Boolean IsNotEmpty(this String source)
		{
			return !String.IsNullOrEmpty(source);
		}

		/// <summary>
		/// Determines whether the <paramref name="source"/> is null or whitespace-only string.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be determined.</param>
		/// <returns><c>true</c> means string is null or whitespace-only, <c>false</c> otherwise.</returns>
		public static Boolean IsBlank(this String source)
		{
			return String.IsNullOrWhiteSpace(source);
		}

		/// <summary>
		/// Determines whether the <paramref name="source"/> is neither null nor whitespace-only string.
		/// </summary>
		/// <param name="source">The <see cref="String"/> to be determined.</param>
		/// <returns><c>true</c> means string is neither null nor whitespace-only, <c>false</c> otherwise.</returns>
		public static Boolean IsNotBlank(this String source)
		{
			return !String.IsNullOrWhiteSpace(source);
		}
	}
}