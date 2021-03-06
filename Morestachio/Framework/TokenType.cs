﻿namespace Morestachio
{
	/// <summary>
	///     The type of token produced in the lexing stage of template compilation.
	/// </summary>
	internal enum TokenType
	{
		EscapedSingleValue,
		UnescapedSingleValue,
		InvertedElementOpen,
		ElementOpen,
		ElementFormat,
		ElementClose,
		Comment,
		Content,
		CollectionOpen,
		CollectionClose,

		/// <summary>
		///     Contains information about the formatting of the values. Must be followed by PrintFormatted or CollectionOpen
		/// </summary>
		Format,

		/// <summary>
		///     Is used to "print" the current formatted value to the output
		/// </summary>
		PrintFormatted
	}
}