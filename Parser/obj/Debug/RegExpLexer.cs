﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\MyPrivateWork\MyApps\MyApplications\EDUFLEX\Parser\RegExpLexer.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Parser {
	using System;
			using System.IO; 
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public partial class RegExpLexer : Lexer {
	public const int
		ID=1, COLON=2, SEMICOLON=3, WS_DEFAULT=4, LB=5, LBH=6, ENDOFLINE=7, STARTOFLINE=8, 
		STARTCODEANCHOR=9, LP=10, RP=11, QMARK=12, DIESIS=13, ANY_EXCEPT_EOL=14, 
		SEMI=15, ONEORMULTIPLE=16, NONEORMULTIPLE=17, ONEORMULTIPLE_NONGREEDY=18, 
		NONEORMULTIPLE_NONGREEDY=19, ALTERNATION=20, ESCSLASH=21, EXMARK=22, LESS=23, 
		EQUAL=24, WS_REGEXP=25, LITERAL_CHARACTER=26, CLOSURE_FLAG=27, STRING_FLAG=28, 
		CODE=29, ENDCODEANCHOR=30, LCA=31, RAC=32, COMMAC=33, NUMBER=34, WS_CLOSURE=35, 
		SET_LITERAL_CHARACTER=36, HYPTHEN=37, RB=38, CONTROL_CHARACTERS=39, INTEGER=40, 
		WS_SET=41, STRING=42;
	public const int REGEXP = 1;
	public const int ACTIONCODE = 2;
	public const int CLOSURE = 3;
	public const int SET = 4;
	public const int STRINGMOD = 5;
	public static string[] modeNames = {
		"DEFAULT_MODE", "REGEXP", "ACTIONCODE", "CLOSURE", "SET", "STRINGMOD"
	};

	public static readonly string[] ruleNames = {
		"ID", "COLON", "SEMICOLON", "WS_DEFAULT", "LB", "LBH", "ENDOFLINE", "STARTOFLINE", 
		"STARTCODEANCHOR", "LP", "RP", "QMARK", "DIESIS", "ANY_EXCEPT_EOL", "SEMI", 
		"ONEORMULTIPLE", "NONEORMULTIPLE", "ONEORMULTIPLE_NONGREEDY", "NONEORMULTIPLE_NONGREEDY", 
		"ALTERNATION", "ESCSLASH", "EXMARK", "LESS", "EQUAL", "WS_REGEXP", "LITERAL_CHARACTER", 
		"CLOSURE_FLAG", "STRING_FLAG", "CODE", "ENDCODEANCHOR", "LCA", "RAC", 
		"COMMAC", "NUMBER", "WS_CLOSURE", "SET_LITERAL_CHARACTER", "HYPTHEN", 
		"RB", "CONTROL_CHARACTERS", "INTEGER", "WS_SET", "INT", "STRING"
	};


					  public static bool guard = true;
					  public static bool guard_string = true;
					  public static int LBindex = 0;
					  public static bool escaped = false;


	public RegExpLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "':'", "';'", null, "'['", "'[^'", "'$'", "'^'", "'{'", "'('", 
		"')'", "'?'", "'#'", "'.'", null, "'+'", "'*'", "'+?'", "'*?'", "'|'", 
		"'\\'", "'!'", "'<'", "'='", null, null, null, null, null, null, "'~{'", 
		null, "','", null, null, null, "'-'", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ID", "COLON", "SEMICOLON", "WS_DEFAULT", "LB", "LBH", "ENDOFLINE", 
		"STARTOFLINE", "STARTCODEANCHOR", "LP", "RP", "QMARK", "DIESIS", "ANY_EXCEPT_EOL", 
		"SEMI", "ONEORMULTIPLE", "NONEORMULTIPLE", "ONEORMULTIPLE_NONGREEDY", 
		"NONEORMULTIPLE_NONGREEDY", "ALTERNATION", "ESCSLASH", "EXMARK", "LESS", 
		"EQUAL", "WS_REGEXP", "LITERAL_CHARACTER", "CLOSURE_FLAG", "STRING_FLAG", 
		"CODE", "ENDCODEANCHOR", "LCA", "RAC", "COMMAC", "NUMBER", "WS_CLOSURE", 
		"SET_LITERAL_CHARACTER", "HYPTHEN", "RB", "CONTROL_CHARACTERS", "INTEGER", 
		"WS_SET", "STRING"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RegExpLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 8 : STARTCODEANCHOR_action(_localctx, actionIndex); break;

		case 14 : SEMI_action(_localctx, actionIndex); break;

		case 20 : ESCSLASH_action(_localctx, actionIndex); break;

		case 26 : CLOSURE_FLAG_action(_localctx, actionIndex); break;

		case 27 : STRING_FLAG_action(_localctx, actionIndex); break;

		case 31 : RAC_action(_localctx, actionIndex); break;

		case 42 : STRING_action(_localctx, actionIndex); break;
		}
	}
	private void STARTCODEANCHOR_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0: if(_input.La(-2)!=92){
									Mode(ACTIONCODE);
							   }
							RegExpLexer.escaped=false; break;
		}
	}
	private void SEMI_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 1: LBindex =InputStream.Index;  break;

		case 2: InputStream.Seek(LBindex);
													Mode(RegExpLexer.DefaultMode); break;
		}
	}
	private void ESCSLASH_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 3: RegExpLexer.escaped=true; break;
		}
	}
	private void CLOSURE_FLAG_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 4: LBindex =InputStream.Index;  break;

		case 5:  RegExpLexer.guard = false;
																		// Go back to the opening brace
																		InputStream.Seek(LBindex);
																		Console.WriteLine("Enter Closure Mode");
																		Mode(CLOSURE);
																	 break;
		}
	}
	private void STRING_FLAG_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 6: LBindex =InputStream.Index;  break;

		case 7:  RegExpLexer.guard_string = false;
										// Go back to the opening brace
										InputStream.Seek(LBindex);
										Console.WriteLine("Enter Literal String Mode");
										Mode(STRINGMOD);
																	 break;
		}
	}
	private void RAC_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 8:  RegExpLexer.guard = true; Mode(RegExpLexer.REGEXP); Console.WriteLine("Enter RegExp Mode");  break;
		}
	}
	private void STRING_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 9:     RegExpLexer.guard_string = true;
								if ( _token !=null )						 
								  Console.WriteLine(_token.Text);
						    break;
		}
	}
	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 26 : return CLOSURE_FLAG_sempred(_localctx, predIndex);

		case 27 : return STRING_FLAG_sempred(_localctx, predIndex);
		}
		return true;
	}
	private bool CLOSURE_FLAG_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return guard;
		}
		return true;
	}
	private bool STRING_FLAG_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return guard_string;
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2,\x113\b\x1\b\x1"+
		"\b\x1\b\x1\b\x1\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6"+
		"\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4"+
		"\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13"+
		"\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19"+
		"\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E"+
		"\x4\x1F\t\x1F\x4 \t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'"+
		"\t\'\x4(\t(\x4)\t)\x4*\t*\x4+\t+\x4,\t,\x3\x2\x3\x2\a\x2\x61\n\x2\f\x2"+
		"\xE\x2\x64\v\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x6\x5m\n\x5"+
		"\r\x5\xE\x5n\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3"+
		"\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11"+
		"\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15"+
		"\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19"+
		"\x3\x1A\x6\x1A\xA9\n\x1A\r\x1A\xE\x1A\xAA\x3\x1A\x3\x1A\x3\x1B\x3\x1B"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x5\x1C\xB9\n"+
		"\x1C\x5\x1C\xBB\n\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\a\x1D\xC6\n\x1D\f\x1D\xE\x1D\xC9\v\x1D\x3\x1D\x3\x1D\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1E\a\x1E\xD1\n\x1E\f\x1E\xE\x1E\xD4\v\x1E\x3\x1F"+
		"\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3!\x3!\x3!\x3\"\x3\"\x3#\x3#\x3$\x6"+
		"$\xE5\n$\r$\xE$\xE6\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3\'\x3\'\x3(\x3"+
		"(\x3(\x3)\x3)\x3*\x6*\xF9\n*\r*\xE*\xFA\x3*\x3*\x3+\x3+\x3+\a+\x102\n"+
		"+\f+\xE+\x105\v+\x5+\x107\n+\x3,\a,\x10A\n,\f,\xE,\x10D\v,\x3,\x3,\x3"+
		",\x3,\x3,\x4\xC7\x10B\x2\x2-\b\x2\x3\n\x2\x4\f\x2\x5\xE\x2\x6\x10\x2\a"+
		"\x12\x2\b\x14\x2\t\x16\x2\n\x18\x2\v\x1A\x2\f\x1C\x2\r\x1E\x2\xE \x2\xF"+
		"\"\x2\x10$\x2\x11&\x2\x12(\x2\x13*\x2\x14,\x2\x15.\x2\x16\x30\x2\x17\x32"+
		"\x2\x18\x34\x2\x19\x36\x2\x1A\x38\x2\x1B:\x2\x1C<\x2\x1D>\x2\x1E@\x2\x1F"+
		"\x42\x2 \x44\x2!\x46\x2\"H\x2#J\x2$L\x2%N\x2&P\x2\'R\x2(T\x2)V\x2*X\x2"+
		"+Z\x2\x2\\\x2,\b\x2\x3\x4\x5\x6\a\v\x4\x2\x43\\\x63|\x6\x2\x32;\x43\\"+
		"\x61\x61\x63|\x5\x2\v\f\xF\xF\"\"\v\x2##%&*-\x30\x30=?\x41\x41]^``}~\x3"+
		"\x2\x7F\x7F\x4\x2//^_\n\x2//\x32\x32^_\x63\x64hhpptvxx\x3\x2\x33;\x3\x2"+
		"\x32;\x118\x2\b\x3\x2\x2\x2\x2\n\x3\x2\x2\x2\x2\f\x3\x2\x2\x2\x2\xE\x3"+
		"\x2\x2\x2\x3\x10\x3\x2\x2\x2\x3\x12\x3\x2\x2\x2\x3\x14\x3\x2\x2\x2\x3"+
		"\x16\x3\x2\x2\x2\x3\x18\x3\x2\x2\x2\x3\x1A\x3\x2\x2\x2\x3\x1C\x3\x2\x2"+
		"\x2\x3\x1E\x3\x2\x2\x2\x3 \x3\x2\x2\x2\x3\"\x3\x2\x2\x2\x3$\x3\x2\x2\x2"+
		"\x3&\x3\x2\x2\x2\x3(\x3\x2\x2\x2\x3*\x3\x2\x2\x2\x3,\x3\x2\x2\x2\x3.\x3"+
		"\x2\x2\x2\x3\x30\x3\x2\x2\x2\x3\x32\x3\x2\x2\x2\x3\x34\x3\x2\x2\x2\x3"+
		"\x36\x3\x2\x2\x2\x3\x38\x3\x2\x2\x2\x3:\x3\x2\x2\x2\x3<\x3\x2\x2\x2\x3"+
		">\x3\x2\x2\x2\x4@\x3\x2\x2\x2\x4\x42\x3\x2\x2\x2\x5\x44\x3\x2\x2\x2\x5"+
		"\x46\x3\x2\x2\x2\x5H\x3\x2\x2\x2\x5J\x3\x2\x2\x2\x5L\x3\x2\x2\x2\x6N\x3"+
		"\x2\x2\x2\x6P\x3\x2\x2\x2\x6R\x3\x2\x2\x2\x6T\x3\x2\x2\x2\x6V\x3\x2\x2"+
		"\x2\x6X\x3\x2\x2\x2\a\\\x3\x2\x2\x2\b^\x3\x2\x2\x2\n\x65\x3\x2\x2\x2\f"+
		"i\x3\x2\x2\x2\xEl\x3\x2\x2\x2\x10r\x3\x2\x2\x2\x12v\x3\x2\x2\x2\x14{\x3"+
		"\x2\x2\x2\x16}\x3\x2\x2\x2\x18\x7F\x3\x2\x2\x2\x1A\x82\x3\x2\x2\x2\x1C"+
		"\x84\x3\x2\x2\x2\x1E\x86\x3\x2\x2\x2 \x88\x3\x2\x2\x2\"\x8A\x3\x2\x2\x2"+
		"$\x8C\x3\x2\x2\x2&\x92\x3\x2\x2\x2(\x94\x3\x2\x2\x2*\x96\x3\x2\x2\x2,"+
		"\x99\x3\x2\x2\x2.\x9C\x3\x2\x2\x2\x30\x9E\x3\x2\x2\x2\x32\xA1\x3\x2\x2"+
		"\x2\x34\xA3\x3\x2\x2\x2\x36\xA5\x3\x2\x2\x2\x38\xA8\x3\x2\x2\x2:\xAE\x3"+
		"\x2\x2\x2<\xB0\x3\x2\x2\x2>\xC1\x3\x2\x2\x2@\xD2\x3\x2\x2\x2\x42\xD5\x3"+
		"\x2\x2\x2\x44\xD9\x3\x2\x2\x2\x46\xDC\x3\x2\x2\x2H\xDF\x3\x2\x2\x2J\xE1"+
		"\x3\x2\x2\x2L\xE4\x3\x2\x2\x2N\xEA\x3\x2\x2\x2P\xEC\x3\x2\x2\x2R\xEE\x3"+
		"\x2\x2\x2T\xF2\x3\x2\x2\x2V\xF5\x3\x2\x2\x2X\xF8\x3\x2\x2\x2Z\x106\x3"+
		"\x2\x2\x2\\\x10B\x3\x2\x2\x2^\x62\t\x2\x2\x2_\x61\t\x3\x2\x2`_\x3\x2\x2"+
		"\x2\x61\x64\x3\x2\x2\x2\x62`\x3\x2\x2\x2\x62\x63\x3\x2\x2\x2\x63\t\x3"+
		"\x2\x2\x2\x64\x62\x3\x2\x2\x2\x65\x66\a<\x2\x2\x66g\x3\x2\x2\x2gh\b\x3"+
		"\x2\x2h\v\x3\x2\x2\x2ij\a=\x2\x2j\r\x3\x2\x2\x2km\t\x4\x2\x2lk\x3\x2\x2"+
		"\x2mn\x3\x2\x2\x2nl\x3\x2\x2\x2no\x3\x2\x2\x2op\x3\x2\x2\x2pq\b\x5\x3"+
		"\x2q\xF\x3\x2\x2\x2rs\a]\x2\x2st\x3\x2\x2\x2tu\b\x6\x4\x2u\x11\x3\x2\x2"+
		"\x2vw\a]\x2\x2wx\a`\x2\x2xy\x3\x2\x2\x2yz\b\a\x4\x2z\x13\x3\x2\x2\x2{"+
		"|\a&\x2\x2|\x15\x3\x2\x2\x2}~\a`\x2\x2~\x17\x3\x2\x2\x2\x7F\x80\a}\x2"+
		"\x2\x80\x81\b\n\x5\x2\x81\x19\x3\x2\x2\x2\x82\x83\a*\x2\x2\x83\x1B\x3"+
		"\x2\x2\x2\x84\x85\a+\x2\x2\x85\x1D\x3\x2\x2\x2\x86\x87\a\x41\x2\x2\x87"+
		"\x1F\x3\x2\x2\x2\x88\x89\a%\x2\x2\x89!\x3\x2\x2\x2\x8A\x8B\a\x30\x2\x2"+
		"\x8B#\x3\x2\x2\x2\x8C\x8D\b\x10\x6\x2\x8D\x8E\a=\x2\x2\x8E\x8F\b\x10\a"+
		"\x2\x8F\x90\x3\x2\x2\x2\x90\x91\b\x10\x3\x2\x91%\x3\x2\x2\x2\x92\x93\a"+
		"-\x2\x2\x93\'\x3\x2\x2\x2\x94\x95\a,\x2\x2\x95)\x3\x2\x2\x2\x96\x97\a"+
		"-\x2\x2\x97\x98\a\x41\x2\x2\x98+\x3\x2\x2\x2\x99\x9A\a,\x2\x2\x9A\x9B"+
		"\a\x41\x2\x2\x9B-\x3\x2\x2\x2\x9C\x9D\a~\x2\x2\x9D/\x3\x2\x2\x2\x9E\x9F"+
		"\a^\x2\x2\x9F\xA0\b\x16\b\x2\xA0\x31\x3\x2\x2\x2\xA1\xA2\a#\x2\x2\xA2"+
		"\x33\x3\x2\x2\x2\xA3\xA4\a>\x2\x2\xA4\x35\x3\x2\x2\x2\xA5\xA6\a?\x2\x2"+
		"\xA6\x37\x3\x2\x2\x2\xA7\xA9\t\x4\x2\x2\xA8\xA7\x3\x2\x2\x2\xA9\xAA\x3"+
		"\x2\x2\x2\xAA\xA8\x3\x2\x2\x2\xAA\xAB\x3\x2\x2\x2\xAB\xAC\x3\x2\x2\x2"+
		"\xAC\xAD\b\x1A\x3\x2\xAD\x39\x3\x2\x2\x2\xAE\xAF\n\x5\x2\x2\xAF;\x3\x2"+
		"\x2\x2\xB0\xB1\x6\x1C\x2\x2\xB1\xB2\b\x1C\t\x2\xB2\xB3\a\x80\x2\x2\xB3"+
		"\xB4\a}\x2\x2\xB4\xB5\x3\x2\x2\x2\xB5\xBA\x5V)\x2\xB6\xB8\a.\x2\x2\xB7"+
		"\xB9\x5V)\x2\xB8\xB7\x3\x2\x2\x2\xB8\xB9\x3\x2\x2\x2\xB9\xBB\x3\x2\x2"+
		"\x2\xBA\xB6\x3\x2\x2\x2\xBA\xBB\x3\x2\x2\x2\xBB\xBC\x3\x2\x2\x2\xBC\xBD"+
		"\a\x7F\x2\x2\xBD\xBE\b\x1C\n\x2\xBE\xBF\x3\x2\x2\x2\xBF\xC0\b\x1C\x3\x2"+
		"\xC0=\x3\x2\x2\x2\xC1\xC2\x6\x1D\x3\x2\xC2\xC3\a)\x2\x2\xC3\xC7\b\x1D"+
		"\v\x2\xC4\xC6\v\x2\x2\x2\xC5\xC4\x3\x2\x2\x2\xC6\xC9\x3\x2\x2\x2\xC7\xC8"+
		"\x3\x2\x2\x2\xC7\xC5\x3\x2\x2\x2\xC8\xCA\x3\x2\x2\x2\xC9\xC7\x3\x2\x2"+
		"\x2\xCA\xCB\a)\x2\x2\xCB\xCC\b\x1D\f\x2\xCC\xCD\x3\x2\x2\x2\xCD\xCE\b"+
		"\x1D\x3\x2\xCE?\x3\x2\x2\x2\xCF\xD1\n\x6\x2\x2\xD0\xCF\x3\x2\x2\x2\xD1"+
		"\xD4\x3\x2\x2\x2\xD2\xD0\x3\x2\x2\x2\xD2\xD3\x3\x2\x2\x2\xD3\x41\x3\x2"+
		"\x2\x2\xD4\xD2\x3\x2\x2\x2\xD5\xD6\a\x7F\x2\x2\xD6\xD7\x3\x2\x2\x2\xD7"+
		"\xD8\b\x1F\r\x2\xD8\x43\x3\x2\x2\x2\xD9\xDA\a\x80\x2\x2\xDA\xDB\a}\x2"+
		"\x2\xDB\x45\x3\x2\x2\x2\xDC\xDD\a\x7F\x2\x2\xDD\xDE\b!\xE\x2\xDEG\x3\x2"+
		"\x2\x2\xDF\xE0\a.\x2\x2\xE0I\x3\x2\x2\x2\xE1\xE2\x5Z+\x2\xE2K\x3\x2\x2"+
		"\x2\xE3\xE5\t\x4\x2\x2\xE4\xE3\x3\x2\x2\x2\xE5\xE6\x3\x2\x2\x2\xE6\xE4"+
		"\x3\x2\x2\x2\xE6\xE7\x3\x2\x2\x2\xE7\xE8\x3\x2\x2\x2\xE8\xE9\b$\x3\x2"+
		"\xE9M\x3\x2\x2\x2\xEA\xEB\n\a\x2\x2\xEBO\x3\x2\x2\x2\xEC\xED\a/\x2\x2"+
		"\xEDQ\x3\x2\x2\x2\xEE\xEF\a_\x2\x2\xEF\xF0\x3\x2\x2\x2\xF0\xF1\b\'\x2"+
		"\x2\xF1S\x3\x2\x2\x2\xF2\xF3\a^\x2\x2\xF3\xF4\t\b\x2\x2\xF4U\x3\x2\x2"+
		"\x2\xF5\xF6\x5Z+\x2\xF6W\x3\x2\x2\x2\xF7\xF9\t\x4\x2\x2\xF8\xF7\x3\x2"+
		"\x2\x2\xF9\xFA\x3\x2\x2\x2\xFA\xF8\x3\x2\x2\x2\xFA\xFB\x3\x2\x2\x2\xFB"+
		"\xFC\x3\x2\x2\x2\xFC\xFD\b*\x3\x2\xFDY\x3\x2\x2\x2\xFE\x107\a\x32\x2\x2"+
		"\xFF\x103\t\t\x2\x2\x100\x102\t\n\x2\x2\x101\x100\x3\x2\x2\x2\x102\x105"+
		"\x3\x2\x2\x2\x103\x101\x3\x2\x2\x2\x103\x104\x3\x2\x2\x2\x104\x107\x3"+
		"\x2\x2\x2\x105\x103\x3\x2\x2\x2\x106\xFE\x3\x2\x2\x2\x106\xFF\x3\x2\x2"+
		"\x2\x107[\x3\x2\x2\x2\x108\x10A\v\x2\x2\x2\x109\x108\x3\x2\x2\x2\x10A"+
		"\x10D\x3\x2\x2\x2\x10B\x10C\x3\x2\x2\x2\x10B\x109\x3\x2\x2\x2\x10C\x10E"+
		"\x3\x2\x2\x2\x10D\x10B\x3\x2\x2\x2\x10E\x10F\a)\x2\x2\x10F\x110\b,\xF"+
		"\x2\x110\x111\x3\x2\x2\x2\x111\x112\b,\x2\x2\x112]\x3\x2\x2\x2\x14\x2"+
		"\x3\x4\x5\x6\a\x62n\xAA\xB8\xBA\xC7\xD2\xE6\xFA\x103\x106\x10B\x10\x4"+
		"\x3\x2\b\x2\x2\x4\x6\x2\x3\n\x2\x3\x10\x3\x3\x10\x4\x3\x16\x5\x3\x1C\x6"+
		"\x3\x1C\a\x3\x1D\b\x3\x1D\t\x4\x2\x2\x3!\n\x3,\v";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Parser
