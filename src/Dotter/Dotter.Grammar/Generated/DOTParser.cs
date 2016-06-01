//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DOT.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class DOTParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, STRICT=11, GRAPH=12, DIGRAPH=13, NODE=14, EDGE=15, SUBGRAPH=16, 
		NUMBER=17, STRING=18, ID=19, HTML_STRING=20, COMMENT=21, LINE_COMMENT=22, 
		PREPROC=23, WS=24;
	public const int
		RULE_graph = 0, RULE_stmt_list = 1, RULE_stmt = 2, RULE_attr_stmt = 3, 
		RULE_attr_list = 4, RULE_a_list = 5, RULE_edge_stmt = 6, RULE_edgeRHS = 7, 
		RULE_edgeop = 8, RULE_node_stmt = 9, RULE_node_id = 10, RULE_port = 11, 
		RULE_subgraph = 12, RULE_id = 13;
	public static readonly string[] ruleNames = {
		"graph", "stmt_list", "stmt", "attr_stmt", "attr_list", "a_list", "edge_stmt", 
		"edgeRHS", "edgeop", "node_stmt", "node_id", "port", "subgraph", "id"
	};

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "';'", "'='", "'['", "']'", "','", "'->'", "'--'", 
		"':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "STRICT", 
		"GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "NUMBER", "STRING", "ID", 
		"HTML_STRING", "COMMENT", "LINE_COMMENT", "PREPROC", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DOT.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public DOTParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class GraphContext : ParserRuleContext {
		public Stmt_listContext stmt_list() {
			return GetRuleContext<Stmt_listContext>(0);
		}
		public ITerminalNode GRAPH() { return GetToken(DOTParser.GRAPH, 0); }
		public ITerminalNode DIGRAPH() { return GetToken(DOTParser.DIGRAPH, 0); }
		public ITerminalNode STRICT() { return GetToken(DOTParser.STRICT, 0); }
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public GraphContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_graph; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterGraph(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitGraph(this);
		}
	}

	[RuleVersion(0)]
	public GraphContext graph() {
		GraphContext _localctx = new GraphContext(Context, State);
		EnterRule(_localctx, 0, RULE_graph);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			_la = TokenStream.La(1);
			if (_la==STRICT) {
				{
				State = 28; Match(STRICT);
				}
			}

			State = 31;
			_la = TokenStream.La(1);
			if ( !(_la==GRAPH || _la==DIGRAPH) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			State = 33;
			_la = TokenStream.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0)) {
				{
				State = 32; id();
				}
			}

			State = 35; Match(T__0);
			State = 36; stmt_list();
			State = 37; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Stmt_listContext : ParserRuleContext {
		public StmtContext[] stmt() {
			return GetRuleContexts<StmtContext>();
		}
		public StmtContext stmt(int i) {
			return GetRuleContext<StmtContext>(i);
		}
		public Stmt_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterStmt_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitStmt_list(this);
		}
	}

	[RuleVersion(0)]
	public Stmt_listContext stmt_list() {
		Stmt_listContext _localctx = new Stmt_listContext(Context, State);
		EnterRule(_localctx, 2, RULE_stmt_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << GRAPH) | (1L << NODE) | (1L << EDGE) | (1L << SUBGRAPH) | (1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0)) {
				{
				{
				State = 39; stmt();
				State = 41;
				_la = TokenStream.La(1);
				if (_la==T__2) {
					{
					State = 40; Match(T__2);
					}
				}

				}
				}
				State = 47;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StmtContext : ParserRuleContext {
		public Node_stmtContext node_stmt() {
			return GetRuleContext<Node_stmtContext>(0);
		}
		public Edge_stmtContext edge_stmt() {
			return GetRuleContext<Edge_stmtContext>(0);
		}
		public Attr_stmtContext attr_stmt() {
			return GetRuleContext<Attr_stmtContext>(0);
		}
		public IdContext[] id() {
			return GetRuleContexts<IdContext>();
		}
		public IdContext id(int i) {
			return GetRuleContext<IdContext>(i);
		}
		public SubgraphContext subgraph() {
			return GetRuleContext<SubgraphContext>(0);
		}
		public StmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitStmt(this);
		}
	}

	[RuleVersion(0)]
	public StmtContext stmt() {
		StmtContext _localctx = new StmtContext(Context, State);
		EnterRule(_localctx, 4, RULE_stmt);
		try {
			State = 56;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 48; node_stmt();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 49; edge_stmt();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 50; attr_stmt();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 51; id();
				State = 52; Match(T__3);
				State = 53; id();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 55; subgraph();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Attr_stmtContext : ParserRuleContext {
		public Attr_listContext attr_list() {
			return GetRuleContext<Attr_listContext>(0);
		}
		public ITerminalNode GRAPH() { return GetToken(DOTParser.GRAPH, 0); }
		public ITerminalNode NODE() { return GetToken(DOTParser.NODE, 0); }
		public ITerminalNode EDGE() { return GetToken(DOTParser.EDGE, 0); }
		public Attr_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attr_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterAttr_stmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitAttr_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Attr_stmtContext attr_stmt() {
		Attr_stmtContext _localctx = new Attr_stmtContext(Context, State);
		EnterRule(_localctx, 6, RULE_attr_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			_la = TokenStream.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << GRAPH) | (1L << NODE) | (1L << EDGE))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			State = 59; attr_list();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Attr_listContext : ParserRuleContext {
		public A_listContext[] a_list() {
			return GetRuleContexts<A_listContext>();
		}
		public A_listContext a_list(int i) {
			return GetRuleContext<A_listContext>(i);
		}
		public Attr_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attr_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterAttr_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitAttr_list(this);
		}
	}

	[RuleVersion(0)]
	public Attr_listContext attr_list() {
		Attr_listContext _localctx = new Attr_listContext(Context, State);
		EnterRule(_localctx, 8, RULE_attr_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			do {
				{
				{
				State = 61; Match(T__4);
				State = 63;
				_la = TokenStream.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0)) {
					{
					State = 62; a_list();
					}
				}

				State = 65; Match(T__5);
				}
				}
				State = 68;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			} while ( _la==T__4 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class A_listContext : ParserRuleContext {
		public IdContext[] id() {
			return GetRuleContexts<IdContext>();
		}
		public IdContext id(int i) {
			return GetRuleContext<IdContext>(i);
		}
		public A_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_a_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterA_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitA_list(this);
		}
	}

	[RuleVersion(0)]
	public A_listContext a_list() {
		A_listContext _localctx = new A_listContext(Context, State);
		EnterRule(_localctx, 10, RULE_a_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			do {
				{
				{
				State = 70; id();
				State = 73;
				_la = TokenStream.La(1);
				if (_la==T__3) {
					{
					State = 71; Match(T__3);
					State = 72; id();
					}
				}

				State = 76;
				_la = TokenStream.La(1);
				if (_la==T__6) {
					{
					State = 75; Match(T__6);
					}
				}

				}
				}
				State = 80;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Edge_stmtContext : ParserRuleContext {
		public EdgeRHSContext edgeRHS() {
			return GetRuleContext<EdgeRHSContext>(0);
		}
		public Node_idContext node_id() {
			return GetRuleContext<Node_idContext>(0);
		}
		public SubgraphContext subgraph() {
			return GetRuleContext<SubgraphContext>(0);
		}
		public Attr_listContext attr_list() {
			return GetRuleContext<Attr_listContext>(0);
		}
		public Edge_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_edge_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterEdge_stmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitEdge_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Edge_stmtContext edge_stmt() {
		Edge_stmtContext _localctx = new Edge_stmtContext(Context, State);
		EnterRule(_localctx, 12, RULE_edge_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84;
			switch (TokenStream.La(1)) {
			case NUMBER:
			case STRING:
			case ID:
			case HTML_STRING:
				{
				State = 82; node_id();
				}
				break;
			case T__0:
			case SUBGRAPH:
				{
				State = 83; subgraph();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 86; edgeRHS();
			State = 88;
			_la = TokenStream.La(1);
			if (_la==T__4) {
				{
				State = 87; attr_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EdgeRHSContext : ParserRuleContext {
		public EdgeopContext[] edgeop() {
			return GetRuleContexts<EdgeopContext>();
		}
		public EdgeopContext edgeop(int i) {
			return GetRuleContext<EdgeopContext>(i);
		}
		public Node_idContext[] node_id() {
			return GetRuleContexts<Node_idContext>();
		}
		public Node_idContext node_id(int i) {
			return GetRuleContext<Node_idContext>(i);
		}
		public SubgraphContext[] subgraph() {
			return GetRuleContexts<SubgraphContext>();
		}
		public SubgraphContext subgraph(int i) {
			return GetRuleContext<SubgraphContext>(i);
		}
		public EdgeRHSContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_edgeRHS; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterEdgeRHS(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitEdgeRHS(this);
		}
	}

	[RuleVersion(0)]
	public EdgeRHSContext edgeRHS() {
		EdgeRHSContext _localctx = new EdgeRHSContext(Context, State);
		EnterRule(_localctx, 14, RULE_edgeRHS);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 95;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			do {
				{
				{
				State = 90; edgeop();
				State = 93;
				switch (TokenStream.La(1)) {
				case NUMBER:
				case STRING:
				case ID:
				case HTML_STRING:
					{
					State = 91; node_id();
					}
					break;
				case T__0:
				case SUBGRAPH:
					{
					State = 92; subgraph();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				}
				State = 97;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			} while ( _la==T__7 || _la==T__8 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EdgeopContext : ParserRuleContext {
		public EdgeopContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_edgeop; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterEdgeop(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitEdgeop(this);
		}
	}

	[RuleVersion(0)]
	public EdgeopContext edgeop() {
		EdgeopContext _localctx = new EdgeopContext(Context, State);
		EnterRule(_localctx, 16, RULE_edgeop);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 99;
			_la = TokenStream.La(1);
			if ( !(_la==T__7 || _la==T__8) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Node_stmtContext : ParserRuleContext {
		public Node_idContext node_id() {
			return GetRuleContext<Node_idContext>(0);
		}
		public Attr_listContext attr_list() {
			return GetRuleContext<Attr_listContext>(0);
		}
		public Node_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_node_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterNode_stmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitNode_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Node_stmtContext node_stmt() {
		Node_stmtContext _localctx = new Node_stmtContext(Context, State);
		EnterRule(_localctx, 18, RULE_node_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 101; node_id();
			State = 103;
			_la = TokenStream.La(1);
			if (_la==T__4) {
				{
				State = 102; attr_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Node_idContext : ParserRuleContext {
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public PortContext port() {
			return GetRuleContext<PortContext>(0);
		}
		public Node_idContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_node_id; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterNode_id(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitNode_id(this);
		}
	}

	[RuleVersion(0)]
	public Node_idContext node_id() {
		Node_idContext _localctx = new Node_idContext(Context, State);
		EnterRule(_localctx, 20, RULE_node_id);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 105; id();
			State = 107;
			_la = TokenStream.La(1);
			if (_la==T__9) {
				{
				State = 106; port();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PortContext : ParserRuleContext {
		public IdContext[] id() {
			return GetRuleContexts<IdContext>();
		}
		public IdContext id(int i) {
			return GetRuleContext<IdContext>(i);
		}
		public PortContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_port; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterPort(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitPort(this);
		}
	}

	[RuleVersion(0)]
	public PortContext port() {
		PortContext _localctx = new PortContext(Context, State);
		EnterRule(_localctx, 22, RULE_port);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 109; Match(T__9);
			State = 110; id();
			State = 113;
			_la = TokenStream.La(1);
			if (_la==T__9) {
				{
				State = 111; Match(T__9);
				State = 112; id();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SubgraphContext : ParserRuleContext {
		public Stmt_listContext stmt_list() {
			return GetRuleContext<Stmt_listContext>(0);
		}
		public ITerminalNode SUBGRAPH() { return GetToken(DOTParser.SUBGRAPH, 0); }
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public SubgraphContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_subgraph; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterSubgraph(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitSubgraph(this);
		}
	}

	[RuleVersion(0)]
	public SubgraphContext subgraph() {
		SubgraphContext _localctx = new SubgraphContext(Context, State);
		EnterRule(_localctx, 24, RULE_subgraph);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 119;
			_la = TokenStream.La(1);
			if (_la==SUBGRAPH) {
				{
				State = 115; Match(SUBGRAPH);
				State = 117;
				_la = TokenStream.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0)) {
					{
					State = 116; id();
					}
				}

				}
			}

			State = 121; Match(T__0);
			State = 122; stmt_list();
			State = 123; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(DOTParser.ID, 0); }
		public ITerminalNode STRING() { return GetToken(DOTParser.STRING, 0); }
		public ITerminalNode HTML_STRING() { return GetToken(DOTParser.HTML_STRING, 0); }
		public ITerminalNode NUMBER() { return GetToken(DOTParser.NUMBER, 0); }
		public IdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_id; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.EnterId(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDOTListener typedListener = listener as IDOTListener;
			if (typedListener != null) typedListener.ExitId(this);
		}
	}

	[RuleVersion(0)]
	public IdContext id() {
		IdContext _localctx = new IdContext(Context, State);
		EnterRule(_localctx, 26, RULE_id);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 125;
			_la = TokenStream.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x1A");
		sb.Append("\x82\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r");
		sb.Append("\t\r\x4\xE\t\xE\x4\xF\t\xF\x3\x2\x5\x2 \n\x2\x3\x2\x3\x2\x5");
		sb.Append("\x2$\n\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x5\x3,\n\x3\a");
		sb.Append("\x3.\n\x3\f\x3\xE\x3\x31\v\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4");
		sb.Append("\x3\x4\x3\x4\x3\x4\x5\x4;\n\x4\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6");
		sb.Append("\x5\x6\x42\n\x6\x3\x6\x6\x6\x45\n\x6\r\x6\xE\x6\x46\x3\a\x3");
		sb.Append("\a\x3\a\x5\aL\n\a\x3\a\x5\aO\n\a\x6\aQ\n\a\r\a\xE\aR\x3\b\x3");
		sb.Append("\b\x5\bW\n\b\x3\b\x3\b\x5\b[\n\b\x3\t\x3\t\x3\t\x5\t`\n\t\x6");
		sb.Append("\t\x62\n\t\r\t\xE\t\x63\x3\n\x3\n\x3\v\x3\v\x5\vj\n\v\x3\f\x3");
		sb.Append("\f\x5\fn\n\f\x3\r\x3\r\x3\r\x3\r\x5\rt\n\r\x3\xE\x3\xE\x5\xE");
		sb.Append("x\n\xE\x5\xEz\n\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF");
		sb.Append("\x2\x2\x10\x2\x4\x6\b\n\f\xE\x10\x12\x14\x16\x18\x1A\x1C\x2");
		sb.Append("\x6\x3\x2\xE\xF\x4\x2\xE\xE\x10\x11\x3\x2\n\v\x3\x2\x13\x16");
		sb.Append("\x89\x2\x1F\x3\x2\x2\x2\x4/\x3\x2\x2\x2\x6:\x3\x2\x2\x2\b<\x3");
		sb.Append("\x2\x2\x2\n\x44\x3\x2\x2\x2\fP\x3\x2\x2\x2\xEV\x3\x2\x2\x2\x10");
		sb.Append("\x61\x3\x2\x2\x2\x12\x65\x3\x2\x2\x2\x14g\x3\x2\x2\x2\x16k\x3");
		sb.Append("\x2\x2\x2\x18o\x3\x2\x2\x2\x1Ay\x3\x2\x2\x2\x1C\x7F\x3\x2\x2");
		sb.Append("\x2\x1E \a\r\x2\x2\x1F\x1E\x3\x2\x2\x2\x1F \x3\x2\x2\x2 !\x3");
		sb.Append("\x2\x2\x2!#\t\x2\x2\x2\"$\x5\x1C\xF\x2#\"\x3\x2\x2\x2#$\x3\x2");
		sb.Append("\x2\x2$%\x3\x2\x2\x2%&\a\x3\x2\x2&\'\x5\x4\x3\x2\'(\a\x4\x2");
		sb.Append("\x2(\x3\x3\x2\x2\x2)+\x5\x6\x4\x2*,\a\x5\x2\x2+*\x3\x2\x2\x2");
		sb.Append("+,\x3\x2\x2\x2,.\x3\x2\x2\x2-)\x3\x2\x2\x2.\x31\x3\x2\x2\x2");
		sb.Append("/-\x3\x2\x2\x2/\x30\x3\x2\x2\x2\x30\x5\x3\x2\x2\x2\x31/\x3\x2");
		sb.Append("\x2\x2\x32;\x5\x14\v\x2\x33;\x5\xE\b\x2\x34;\x5\b\x5\x2\x35");
		sb.Append("\x36\x5\x1C\xF\x2\x36\x37\a\x6\x2\x2\x37\x38\x5\x1C\xF\x2\x38");
		sb.Append(";\x3\x2\x2\x2\x39;\x5\x1A\xE\x2:\x32\x3\x2\x2\x2:\x33\x3\x2");
		sb.Append("\x2\x2:\x34\x3\x2\x2\x2:\x35\x3\x2\x2\x2:\x39\x3\x2\x2\x2;\a");
		sb.Append("\x3\x2\x2\x2<=\t\x3\x2\x2=>\x5\n\x6\x2>\t\x3\x2\x2\x2?\x41\a");
		sb.Append("\a\x2\x2@\x42\x5\f\a\x2\x41@\x3\x2\x2\x2\x41\x42\x3\x2\x2\x2");
		sb.Append("\x42\x43\x3\x2\x2\x2\x43\x45\a\b\x2\x2\x44?\x3\x2\x2\x2\x45");
		sb.Append("\x46\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2\x46G\x3\x2\x2\x2G\v\x3");
		sb.Append("\x2\x2\x2HK\x5\x1C\xF\x2IJ\a\x6\x2\x2JL\x5\x1C\xF\x2KI\x3\x2");
		sb.Append("\x2\x2KL\x3\x2\x2\x2LN\x3\x2\x2\x2MO\a\t\x2\x2NM\x3\x2\x2\x2");
		sb.Append("NO\x3\x2\x2\x2OQ\x3\x2\x2\x2PH\x3\x2\x2\x2QR\x3\x2\x2\x2RP\x3");
		sb.Append("\x2\x2\x2RS\x3\x2\x2\x2S\r\x3\x2\x2\x2TW\x5\x16\f\x2UW\x5\x1A");
		sb.Append("\xE\x2VT\x3\x2\x2\x2VU\x3\x2\x2\x2WX\x3\x2\x2\x2XZ\x5\x10\t");
		sb.Append("\x2Y[\x5\n\x6\x2ZY\x3\x2\x2\x2Z[\x3\x2\x2\x2[\xF\x3\x2\x2\x2");
		sb.Append("\\_\x5\x12\n\x2]`\x5\x16\f\x2^`\x5\x1A\xE\x2_]\x3\x2\x2\x2_");
		sb.Append("^\x3\x2\x2\x2`\x62\x3\x2\x2\x2\x61\\\x3\x2\x2\x2\x62\x63\x3");
		sb.Append("\x2\x2\x2\x63\x61\x3\x2\x2\x2\x63\x64\x3\x2\x2\x2\x64\x11\x3");
		sb.Append("\x2\x2\x2\x65\x66\t\x4\x2\x2\x66\x13\x3\x2\x2\x2gi\x5\x16\f");
		sb.Append("\x2hj\x5\n\x6\x2ih\x3\x2\x2\x2ij\x3\x2\x2\x2j\x15\x3\x2\x2\x2");
		sb.Append("km\x5\x1C\xF\x2ln\x5\x18\r\x2ml\x3\x2\x2\x2mn\x3\x2\x2\x2n\x17");
		sb.Append("\x3\x2\x2\x2op\a\f\x2\x2ps\x5\x1C\xF\x2qr\a\f\x2\x2rt\x5\x1C");
		sb.Append("\xF\x2sq\x3\x2\x2\x2st\x3\x2\x2\x2t\x19\x3\x2\x2\x2uw\a\x12");
		sb.Append("\x2\x2vx\x5\x1C\xF\x2wv\x3\x2\x2\x2wx\x3\x2\x2\x2xz\x3\x2\x2");
		sb.Append("\x2yu\x3\x2\x2\x2yz\x3\x2\x2\x2z{\x3\x2\x2\x2{|\a\x3\x2\x2|");
		sb.Append("}\x5\x4\x3\x2}~\a\x4\x2\x2~\x1B\x3\x2\x2\x2\x7F\x80\t\x5\x2");
		sb.Append("\x2\x80\x1D\x3\x2\x2\x2\x15\x1F#+/:\x41\x46KNRVZ_\x63imswy");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
