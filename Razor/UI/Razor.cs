using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Assistant.Filters;
using Assistant.Macros;

namespace Assistant
{
	public class MainForm : System.Windows.Forms.Form
	{
		#region Class Variables
		private System.Windows.Forms.NotifyIcon m_NotifyIcon;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckedListBox filters;
		private System.Windows.Forms.ColumnHeader skillHDRName;
		private System.Windows.Forms.ColumnHeader skillHDRvalue;
		private System.Windows.Forms.ColumnHeader skillHDRbase;
        private System.Windows.Forms.ColumnHeader skillHDRdelta;
        private RazorUIMod.XButton resetDelta;
        private RazorUIMod.XButton setlocks;
        private RazorUIMod.XComboBox locks;
		private System.Windows.Forms.ListView skillList;
		private System.Windows.Forms.ColumnHeader skillHDRcap;
        private System.Windows.Forms.GroupBox groupBox2;
        private RazorUIMod.XButton addCounter;
        private RazorUIMod.XButton delCounter;
        private System.Windows.Forms.GroupBox groupBox3;
        private RazorUIMod.XCheckBox showInBar;
        private System.Windows.Forms.TextBox titleStr;
        private RazorUIMod.XCheckBox checkNewConts;
        private System.Windows.Forms.Timer timerTimer;
        private RazorUIMod.XCheckBox alwaysTop;
		private System.Windows.Forms.ColumnHeader cntName;
		private System.Windows.Forms.ColumnHeader cntCount;
		private System.Windows.Forms.ListView counters;
        private System.Windows.Forms.GroupBox groupBox4;
        private RazorUIMod.XButton newProfile;
        private RazorUIMod.XButton delProfile;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baseTotal;
        private System.Windows.Forms.TabPage dressTab;
        private RazorUIMod.XButton skillCopySel;
        private RazorUIMod.XButton skillCopyAll;
        private System.Windows.Forms.GroupBox groupBox5;
        private RazorUIMod.XButton removeDress;
        private RazorUIMod.XButton addDress;
		private System.Windows.Forms.ListBox dressList;
        private System.Windows.Forms.GroupBox groupBox6;
        private RazorUIMod.XButton targItem;
        private System.Windows.Forms.ListBox dressItems;
        private RazorUIMod.XButton dressUseCur;
		private System.Windows.Forms.TabPage generalTab;
		private System.Windows.Forms.TabPage displayTab;
		private System.Windows.Forms.TabPage skillsTab;
        private System.Windows.Forms.TabPage hotkeysTab;
        private RazorUIMod.XCheckBox chkCtrl;
        private RazorUIMod.XCheckBox chkAlt;
        private RazorUIMod.XCheckBox chkShift;
		private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox key;
        private RazorUIMod.XButton setHK;
        private RazorUIMod.XButton unsetHK;
        private System.Windows.Forms.Label label2;
        private RazorUIMod.XCheckBox chkPass;
        private System.Windows.Forms.TabPage moreOptTab;
        private RazorUIMod.XCheckBox chkForceSpeechHue;
		private System.Windows.Forms.Label label3;
        private RazorUIMod.XTextBox txtSpellFormat;
        private RazorUIMod.XCheckBox chkForceSpellHue;
        private RazorUIMod.XCheckBox chkStealth;
		private System.Windows.Forms.TabPage agentsTab;
		private System.Windows.Forms.GroupBox agentGroup;
        private System.Windows.Forms.ListBox agentSubList;
        private RazorUIMod.XButton agentB1;
        private RazorUIMod.XButton agentB2;
        private RazorUIMod.XButton agentB3;
        private RazorUIMod.XButton dohotkey;
        private RazorUIMod.XButton agentB4;
		private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacity;
        private RazorUIMod.XCheckBox dispDelta;
        private RazorUIMod.XComboBox agentList;
        private RazorUIMod.XButton recount;
        private RazorUIMod.XCheckBox openCorpses;
        private RazorUIMod.XTextBox corpseRange;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage macrosTab;
		private System.Windows.Forms.TreeView hotkeyTree;
		private System.Windows.Forms.TabPage screenshotTab;
        private System.Windows.Forms.TabPage statusTab;
        private RazorUIMod.XButton newMacro;
        private RazorUIMod.XButton delMacro;
		private System.Windows.Forms.GroupBox macroActGroup;
        private System.Windows.Forms.ListBox actionList;
        private RazorUIMod.XButton playMacro;
        private RazorUIMod.XButton recMacro;
        private RazorUIMod.XCheckBox loopMacro;
        private RazorUIMod.XButton dressNow;
        private RazorUIMod.XButton undressList;
        private RazorUIMod.XCheckBox spamFilter;
		private System.Windows.Forms.PictureBox screenPrev;
        private System.Windows.Forms.ListBox screensList;
        private RazorUIMod.XButton setScnPath;
        private RazorUIMod.XRadioButton radioFull;
        private RazorUIMod.XRadioButton radioUO;
        private RazorUIMod.XCheckBox screenAutoCap;
        private RazorUIMod.XTextBox screenPath;
        private RazorUIMod.XButton capNow;
        private RazorUIMod.XCheckBox dispTime;
        private RazorUIMod.XButton agentB5;
        private RazorUIMod.XButton agentB6;
        private RazorUIMod.XCheckBox undressConflicts;
        private RazorUIMod.XCheckBox titlebarImages;
        private RazorUIMod.XCheckBox showWelcome;
        private RazorUIMod.XCheckBox highlightSpellReags;
		private System.Windows.Forms.ColumnHeader skillHDRlock;
        private System.ComponentModel.IContainer components;
        private RazorUIMod.XCheckBox queueTargets;
        private RazorUIMod.XRadioButton systray;
        private RazorUIMod.XRadioButton taskbar;
        private System.Windows.Forms.Label label11;
        private RazorUIMod.XCheckBox autoStackRes;
        private RazorUIMod.XButton undressBag;
        private RazorUIMod.XButton dressDelSel;
        private RazorUIMod.XButton setExHue;
        private RazorUIMod.XButton setMsgHue;
        private RazorUIMod.XButton setWarnHue;
        private RazorUIMod.XButton setSpeechHue;
        private RazorUIMod.XButton setBeneHue;
        private RazorUIMod.XButton setHarmHue;
        private RazorUIMod.XButton setNeuHue;
		private System.Windows.Forms.Label lblWarnHue;
		private System.Windows.Forms.Label lblMsgHue;
		private System.Windows.Forms.Label lblExHue;
		private System.Windows.Forms.Label lblBeneHue;
		private System.Windows.Forms.Label lblHarmHue;
        private System.Windows.Forms.Label lblNeuHue;
        private RazorUIMod.XCheckBox incomingCorpse;
        private RazorUIMod.XCheckBox incomingMob;
        private RazorUIMod.XComboBox langSel;
        private System.Windows.Forms.Label label7;
        private RazorUIMod.XComboBox profiles;
        private System.Windows.Forms.Label hkStatus;
        private RazorUIMod.XButton clearDress;
        private System.Windows.Forms.TabPage moreMoreOptTab;
        private RazorUIMod.XCheckBox actionStatusMsg;
        private RazorUIMod.XTextBox txtObjDelay;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RazorUIMod.XCheckBox QueueActions;
        private RazorUIMod.XCheckBox rangeCheckLT;
        private RazorUIMod.XTextBox ltRange;
        private System.Windows.Forms.Label label8;
        private RazorUIMod.XCheckBox excludePouches;
        private RazorUIMod.XCheckBox logPackets;
        private RazorUIMod.XCheckBox filterSnoop;
        private RazorUIMod.XCheckBox smartLT;
        private RazorUIMod.XCheckBox showtargtext;
        private RazorUIMod.XCheckBox smartCPU;
        private System.Windows.Forms.Label waitDisp;
        private RazorUIMod.XButton setLTHilight;
        private RazorUIMod.XCheckBox lthilight;
        private RazorUIMod.XCheckBox rememberPwds;
        private RazorUIMod.XCheckBox blockDis;
        private System.Windows.Forms.Label label12;
        private RazorUIMod.XComboBox imgFmt;
        private System.Windows.Forms.TabPage videoTab;
        private RazorUIMod.XButton vidRec;
		private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private RazorUIMod.XButton vidOpen;
        private RazorUIMod.XButton vidPlay;
        private RazorUIMod.XButton vidPlayStop;
		private System.Windows.Forms.Label vidPlayInfo;
        private System.Windows.Forms.TrackBar playPos;
        private RazorUIMod.XButton vidClose;
        private System.Windows.Forms.Label label14;
        private RazorUIMod.XComboBox playSpeed;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Label label15;
        private RazorUIMod.XTextBox aviFPS;
        private System.Windows.Forms.Label label16;
        private RazorUIMod.XComboBox aviRes;
        private RazorUIMod.XButton recAVI;
        private RazorUIMod.XButton recFolder;
		private System.Windows.Forms.Label label13;
        private RazorUIMod.XTextBox txtRecFolder;
		private System.Windows.Forms.TreeView macroTree;
		private ToolTip m_Tip;
		#endregion

		private int m_LastKV = 0;
		private bool m_ProfileConfirmLoad;
        private RazorUIMod.XCheckBox spellUnequip;
        private RazorUIMod.XCheckBox autoFriend;
        private RazorUIMod.XCheckBox alwaysStealth;
        private RazorUIMod.XCheckBox autoOpenDoors;
        private System.Windows.Forms.Label label17;
        private RazorUIMod.XComboBox msglvl;
        private RazorUIMod.XTextBox forceSizeX;
        private RazorUIMod.XTextBox forceSizeY;
		private System.Windows.Forms.Label label18;
        private RazorUIMod.XCheckBox gameSize;
        private RazorUIMod.XCheckBox flipVidHoriz;
        private RazorUIMod.XCheckBox flipVidVert;
		private System.Windows.Forms.Label label19;
        private RazorUIMod.XCheckBox potionEquip;
        private RazorUIMod.XTextBox warnNum;
        private RazorUIMod.XCheckBox warnCount;
        private RazorUIMod.XCheckBox blockHealPoison;
        private RazorUIMod.XCheckBox negotiate;
		private System.Windows.Forms.LinkLabel wikiLink;
		private System.Windows.Forms.LinkLabel homeLink;
		private System.Windows.Forms.LinkLabel issuesLink;
		private System.Windows.Forms.TextBox features;
        private System.Windows.Forms.PictureBox lockBox;
        private RazorUIMod.XButton btnMap;
		private System.Windows.Forms.Label rpvTime;
        private RazorUIMod.XCheckBox showNotoHue;
        private RazorUIMod.XCheckBox preAOSstatbar;
        private RazorUIMod.XCheckBox showHealthOH;
		private System.Windows.Forms.Label label10;
        private RazorUIMod.XTextBox healthFmt;
        private RazorUIMod.XComboBox clientPrio;
		private System.Windows.Forms.Label label9;
        private RazorUIMod.XCheckBox chkPartyOverhead;
		private Label btcLabel;
		private TextBox textBox1;
		private TextBox statusBox;
        private RazorUIMod.XButton exportProfile;
        private RazorUIMod.XButton importProfile;
        private RazorUIMod.XButton adveditorMacro;
        private RazorUIMod.XButton macroImport;
        private RazorUIMod.XButton exportMacro;

		private bool m_CanClose = true;

		[DllImport( "User32.dll" )]
		private static extern IntPtr GetSystemMenu( IntPtr wnd, bool reset );
		[DllImport( "User32.dll" )]
		private static extern IntPtr EnableMenuItem( IntPtr menu, uint item, uint options );

		public Label WaitDisplay { get{ return waitDisp; } }

		public MainForm()
		{
			m_ProfileConfirmLoad = true;
			m_Tip = new ToolTip();
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			m_NotifyIcon.ContextMenu = 
				new ContextMenu( new MenuItem[]
				{
					new MenuItem( "Show Razor", new EventHandler( DoShowMe ) ),
					new MenuItem( "Hide Razor", new EventHandler( HideMe ) ),
					new MenuItem( "-" ),
					new MenuItem( "Toggle Razor Visibility", new EventHandler( ToggleVisible ) ),
					new MenuItem( "-" ),
					new MenuItem( "Close Razor && UO", new EventHandler( OnClose ) ),
				} );
			m_NotifyIcon.ContextMenu.MenuItems[0].DefaultItem = true;
		}

		public void SwitchToVidTab()
		{
			tabs.SelectedTab = videoTab;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            RazorUIMod.Colortable colortable2 = new RazorUIMod.Colortable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RazorUIMod.Office2010Blue office2010Blue2 = new RazorUIMod.Office2010Blue();
            RazorUIMod.Office2010Blue office2010Blue1 = new RazorUIMod.Office2010Blue();
            this.playMacro = new RazorUIMod.XButton();
            this.m_NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.clientPrio = new RazorUIMod.XComboBox();
            this.btnMap = new RazorUIMod.XButton();
            this.lockBox = new System.Windows.Forms.PictureBox();
            this.systray = new RazorUIMod.XRadioButton();
            this.taskbar = new RazorUIMod.XRadioButton();
            this.smartCPU = new RazorUIMod.XCheckBox();
            this.langSel = new RazorUIMod.XComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.importProfile = new RazorUIMod.XButton();
            this.exportProfile = new RazorUIMod.XButton();
            this.delProfile = new RazorUIMod.XButton();
            this.newProfile = new RazorUIMod.XButton();
            this.profiles = new RazorUIMod.XComboBox();
            this.showWelcome = new RazorUIMod.XCheckBox();
            this.opacity = new System.Windows.Forms.TrackBar();
            this.alwaysTop = new RazorUIMod.XCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filters = new System.Windows.Forms.CheckedListBox();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.moreOptTab = new System.Windows.Forms.TabPage();
            this.preAOSstatbar = new RazorUIMod.XCheckBox();
            this.negotiate = new RazorUIMod.XCheckBox();
            this.setLTHilight = new RazorUIMod.XButton();
            this.lthilight = new RazorUIMod.XCheckBox();
            this.filterSnoop = new RazorUIMod.XCheckBox();
            this.corpseRange = new RazorUIMod.XTextBox();
            this.incomingCorpse = new RazorUIMod.XCheckBox();
            this.incomingMob = new RazorUIMod.XCheckBox();
            this.setHarmHue = new RazorUIMod.XButton();
            this.setNeuHue = new RazorUIMod.XButton();
            this.lblHarmHue = new System.Windows.Forms.Label();
            this.lblNeuHue = new System.Windows.Forms.Label();
            this.lblBeneHue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWarnHue = new System.Windows.Forms.Label();
            this.lblMsgHue = new System.Windows.Forms.Label();
            this.lblExHue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setBeneHue = new RazorUIMod.XButton();
            this.setSpeechHue = new RazorUIMod.XButton();
            this.setWarnHue = new RazorUIMod.XButton();
            this.setMsgHue = new RazorUIMod.XButton();
            this.setExHue = new RazorUIMod.XButton();
            this.autoStackRes = new RazorUIMod.XCheckBox();
            this.queueTargets = new RazorUIMod.XCheckBox();
            this.spamFilter = new RazorUIMod.XCheckBox();
            this.openCorpses = new RazorUIMod.XCheckBox();
            this.blockDis = new RazorUIMod.XCheckBox();
            this.txtSpellFormat = new RazorUIMod.XTextBox();
            this.chkForceSpellHue = new RazorUIMod.XCheckBox();
            this.chkForceSpeechHue = new RazorUIMod.XCheckBox();
            this.moreMoreOptTab = new System.Windows.Forms.TabPage();
            this.msglvl = new RazorUIMod.XComboBox();
            this.forceSizeX = new RazorUIMod.XTextBox();
            this.forceSizeY = new RazorUIMod.XTextBox();
            this.healthFmt = new RazorUIMod.XTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.showHealthOH = new RazorUIMod.XCheckBox();
            this.blockHealPoison = new RazorUIMod.XCheckBox();
            this.ltRange = new RazorUIMod.XTextBox();
            this.potionEquip = new RazorUIMod.XCheckBox();
            this.txtObjDelay = new RazorUIMod.XTextBox();
            this.QueueActions = new RazorUIMod.XCheckBox();
            this.spellUnequip = new RazorUIMod.XCheckBox();
            this.autoOpenDoors = new RazorUIMod.XCheckBox();
            this.alwaysStealth = new RazorUIMod.XCheckBox();
            this.autoFriend = new RazorUIMod.XCheckBox();
            this.chkStealth = new RazorUIMod.XCheckBox();
            this.rememberPwds = new RazorUIMod.XCheckBox();
            this.showtargtext = new RazorUIMod.XCheckBox();
            this.logPackets = new RazorUIMod.XCheckBox();
            this.rangeCheckLT = new RazorUIMod.XCheckBox();
            this.actionStatusMsg = new RazorUIMod.XCheckBox();
            this.smartLT = new RazorUIMod.XCheckBox();
            this.gameSize = new RazorUIMod.XCheckBox();
            this.chkPartyOverhead = new RazorUIMod.XCheckBox();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.showNotoHue = new RazorUIMod.XCheckBox();
            this.warnNum = new RazorUIMod.XTextBox();
            this.warnCount = new RazorUIMod.XCheckBox();
            this.excludePouches = new RazorUIMod.XCheckBox();
            this.highlightSpellReags = new RazorUIMod.XCheckBox();
            this.titlebarImages = new RazorUIMod.XCheckBox();
            this.checkNewConts = new RazorUIMod.XCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.titleStr = new System.Windows.Forms.TextBox();
            this.showInBar = new RazorUIMod.XCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.counters = new System.Windows.Forms.ListView();
            this.cntName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delCounter = new RazorUIMod.XButton();
            this.addCounter = new RazorUIMod.XButton();
            this.recount = new RazorUIMod.XButton();
            this.dressTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clearDress = new RazorUIMod.XButton();
            this.dressDelSel = new RazorUIMod.XButton();
            this.undressBag = new RazorUIMod.XButton();
            this.undressList = new RazorUIMod.XButton();
            this.dressUseCur = new RazorUIMod.XButton();
            this.targItem = new RazorUIMod.XButton();
            this.dressItems = new System.Windows.Forms.ListBox();
            this.dressNow = new RazorUIMod.XButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.removeDress = new RazorUIMod.XButton();
            this.addDress = new RazorUIMod.XButton();
            this.dressList = new System.Windows.Forms.ListBox();
            this.undressConflicts = new RazorUIMod.XCheckBox();
            this.skillsTab = new System.Windows.Forms.TabPage();
            this.dispDelta = new RazorUIMod.XCheckBox();
            this.skillCopyAll = new RazorUIMod.XButton();
            this.skillCopySel = new RazorUIMod.XButton();
            this.baseTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locks = new RazorUIMod.XComboBox();
            this.setlocks = new RazorUIMod.XButton();
            this.resetDelta = new RazorUIMod.XButton();
            this.skillList = new System.Windows.Forms.ListView();
            this.skillHDRName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillHDRvalue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillHDRbase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillHDRdelta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillHDRcap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillHDRlock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agentsTab = new System.Windows.Forms.TabPage();
            this.agentB6 = new RazorUIMod.XButton();
            this.agentB5 = new RazorUIMod.XButton();
            this.agentList = new RazorUIMod.XComboBox();
            this.agentGroup = new System.Windows.Forms.GroupBox();
            this.agentSubList = new System.Windows.Forms.ListBox();
            this.agentB4 = new RazorUIMod.XButton();
            this.agentB1 = new RazorUIMod.XButton();
            this.agentB2 = new RazorUIMod.XButton();
            this.agentB3 = new RazorUIMod.XButton();
            this.hotkeysTab = new System.Windows.Forms.TabPage();
            this.hkStatus = new System.Windows.Forms.Label();
            this.hotkeyTree = new System.Windows.Forms.TreeView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkPass = new RazorUIMod.XCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unsetHK = new RazorUIMod.XButton();
            this.setHK = new RazorUIMod.XButton();
            this.key = new System.Windows.Forms.TextBox();
            this.chkCtrl = new RazorUIMod.XCheckBox();
            this.chkAlt = new RazorUIMod.XCheckBox();
            this.chkShift = new RazorUIMod.XCheckBox();
            this.dohotkey = new RazorUIMod.XButton();
            this.macrosTab = new System.Windows.Forms.TabPage();
            this.macroTree = new System.Windows.Forms.TreeView();
            this.macroActGroup = new System.Windows.Forms.GroupBox();
            this.adveditorMacro = new RazorUIMod.XButton();
            this.macroImport = new RazorUIMod.XButton();
            this.exportMacro = new RazorUIMod.XButton();
            this.waitDisp = new System.Windows.Forms.Label();
            this.loopMacro = new RazorUIMod.XCheckBox();
            this.recMacro = new RazorUIMod.XButton();
            this.actionList = new System.Windows.Forms.ListBox();
            this.delMacro = new RazorUIMod.XButton();
            this.newMacro = new RazorUIMod.XButton();
            this.videoTab = new System.Windows.Forms.TabPage();
            this.txtRecFolder = new RazorUIMod.XTextBox();
            this.recFolder = new RazorUIMod.XButton();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.vidRec = new RazorUIMod.XButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flipVidVert = new RazorUIMod.XCheckBox();
            this.flipVidHoriz = new RazorUIMod.XCheckBox();
            this.recAVI = new RazorUIMod.XButton();
            this.aviRes = new RazorUIMod.XComboBox();
            this.aviFPS = new RazorUIMod.XTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rpvTime = new System.Windows.Forms.Label();
            this.playSpeed = new RazorUIMod.XComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vidClose = new RazorUIMod.XButton();
            this.playPos = new System.Windows.Forms.TrackBar();
            this.vidPlayStop = new RazorUIMod.XButton();
            this.vidPlay = new RazorUIMod.XButton();
            this.vidPlayInfo = new System.Windows.Forms.Label();
            this.vidOpen = new RazorUIMod.XButton();
            this.screenshotTab = new System.Windows.Forms.TabPage();
            this.imgFmt = new RazorUIMod.XComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.capNow = new RazorUIMod.XButton();
            this.screenPath = new RazorUIMod.XTextBox();
            this.radioUO = new RazorUIMod.XRadioButton();
            this.radioFull = new RazorUIMod.XRadioButton();
            this.screenAutoCap = new RazorUIMod.XCheckBox();
            this.setScnPath = new RazorUIMod.XButton();
            this.screensList = new System.Windows.Forms.ListBox();
            this.screenPrev = new System.Windows.Forms.PictureBox();
            this.dispTime = new RazorUIMod.XCheckBox();
            this.statusTab = new System.Windows.Forms.TabPage();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btcLabel = new System.Windows.Forms.Label();
            this.features = new System.Windows.Forms.TextBox();
            this.issuesLink = new System.Windows.Forms.LinkLabel();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.wikiLink = new System.Windows.Forms.LinkLabel();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.moreOptTab.SuspendLayout();
            this.moreMoreOptTab.SuspendLayout();
            this.displayTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dressTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.skillsTab.SuspendLayout();
            this.agentsTab.SuspendLayout();
            this.agentGroup.SuspendLayout();
            this.hotkeysTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.macrosTab.SuspendLayout();
            this.macroActGroup.SuspendLayout();
            this.videoTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPos)).BeginInit();
            this.screenshotTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenPrev)).BeginInit();
            this.statusTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // playMacro
            // 
            colortable2.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            colortable2.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            colortable2.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            colortable2.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            colortable2.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            colortable2.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            colortable2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            colortable2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            colortable2.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            colortable2.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            colortable2.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            colortable2.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            colortable2.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            colortable2.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            colortable2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            colortable2.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            colortable2.TextColor = System.Drawing.Color.White;
            this.playMacro.ColorTable = colortable2;
            this.playMacro.Location = new System.Drawing.Point(373, 21);
            this.playMacro.Name = "playMacro";
            this.playMacro.Size = new System.Drawing.Size(72, 23);
            this.playMacro.TabIndex = 9;
            this.playMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            // 
            // m_NotifyIcon
            // 
            this.m_NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_NotifyIcon.Icon")));
            this.m_NotifyIcon.Text = "Razor";
            this.m_NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.generalTab);
            this.tabs.Controls.Add(this.moreOptTab);
            this.tabs.Controls.Add(this.moreMoreOptTab);
            this.tabs.Controls.Add(this.displayTab);
            this.tabs.Controls.Add(this.dressTab);
            this.tabs.Controls.Add(this.skillsTab);
            this.tabs.Controls.Add(this.agentsTab);
            this.tabs.Controls.Add(this.hotkeysTab);
            this.tabs.Controls.Add(this.macrosTab);
            this.tabs.Controls.Add(this.videoTab);
            this.tabs.Controls.Add(this.screenshotTab);
            this.tabs.Controls.Add(this.statusTab);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(648, 373);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_IndexChanged);
            this.tabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabs_KeyDown);
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.clientPrio);
            this.generalTab.Controls.Add(this.btnMap);
            this.generalTab.Controls.Add(this.lockBox);
            this.generalTab.Controls.Add(this.systray);
            this.generalTab.Controls.Add(this.taskbar);
            this.generalTab.Controls.Add(this.smartCPU);
            this.generalTab.Controls.Add(this.langSel);
            this.generalTab.Controls.Add(this.label7);
            this.generalTab.Controls.Add(this.label11);
            this.generalTab.Controls.Add(this.groupBox4);
            this.generalTab.Controls.Add(this.showWelcome);
            this.generalTab.Controls.Add(this.opacity);
            this.generalTab.Controls.Add(this.alwaysTop);
            this.generalTab.Controls.Add(this.groupBox1);
            this.generalTab.Controls.Add(this.opacityLabel);
            this.generalTab.Controls.Add(this.label9);
            this.generalTab.Location = new System.Drawing.Point(4, 46);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(640, 323);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            // 
            // clientPrio
            // 
            this.clientPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientPrio.Items.AddRange(new object[] {
            "Idle",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "High",
            "Realtime"});
            this.clientPrio.Location = new System.Drawing.Point(356, 147);
            this.clientPrio.Name = "clientPrio";
            this.clientPrio.Size = new System.Drawing.Size(106, 28);
            this.clientPrio.TabIndex = 60;
            // 
            // btnMap
            // 
            office2010Blue2.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue2.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue2.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue2.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue2.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue2.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue2.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue2.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue2.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue2.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue2.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue2.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue2.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue2.TextColor = System.Drawing.Color.White;
            this.btnMap.ColorTable = office2010Blue2;
            this.btnMap.Location = new System.Drawing.Point(3, 289);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(195, 26);
            this.btnMap.TabIndex = 58;
            this.btnMap.Text = "Open UO Positioning System";
            this.btnMap.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lockBox
            // 
            this.lockBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.lockBox.Image = ((System.Drawing.Image)(resources.GetObject("lockBox.Image")));
            this.lockBox.Location = new System.Drawing.Point(492, 110);
            this.lockBox.Name = "lockBox";
            this.lockBox.Size = new System.Drawing.Size(16, 16);
            this.lockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lockBox.TabIndex = 56;
            this.lockBox.TabStop = false;
            this.lockBox.Visible = false;
            this.lockBox.Click += new System.EventHandler(this.lockBox_Click);
            // 
            // systray
            // 
            this.systray.Location = new System.Drawing.Point(356, 114);
            this.systray.Name = "systray";
            this.systray.Size = new System.Drawing.Size(103, 23);
            this.systray.TabIndex = 35;
            this.systray.Text = "System Tray";
            this.systray.CheckedChanged += new System.EventHandler(this.systray_CheckedChanged);
            // 
            // taskbar
            // 
            this.taskbar.Location = new System.Drawing.Point(282, 114);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(76, 23);
            this.taskbar.TabIndex = 34;
            this.taskbar.Text = "Taskbar";
            this.taskbar.CheckedChanged += new System.EventHandler(this.taskbar_CheckedChanged);
            // 
            // smartCPU
            // 
            this.smartCPU.Location = new System.Drawing.Point(224, 56);
            this.smartCPU.Name = "smartCPU";
            this.smartCPU.Size = new System.Drawing.Size(290, 23);
            this.smartCPU.TabIndex = 53;
            this.smartCPU.Text = "Use smart CPU usage reduction";
            this.smartCPU.CheckedChanged += new System.EventHandler(this.smartCPU_CheckedChanged);
            // 
            // langSel
            // 
            this.langSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langSel.Location = new System.Drawing.Point(356, 187);
            this.langSel.Name = "langSel";
            this.langSel.Size = new System.Drawing.Size(60, 28);
            this.langSel.TabIndex = 52;
            this.langSel.SelectedIndexChanged += new System.EventHandler(this.langSel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(221, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Language:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(224, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Show in:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.importProfile);
            this.groupBox4.Controls.Add(this.exportProfile);
            this.groupBox4.Controls.Add(this.delProfile);
            this.groupBox4.Controls.Add(this.newProfile);
            this.groupBox4.Controls.Add(this.profiles);
            this.groupBox4.Location = new System.Drawing.Point(214, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 49);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profiles";
            // 
            // importProfile
            // 
            this.importProfile.ColorTable = office2010Blue1;
            this.importProfile.Location = new System.Drawing.Point(357, 18);
            this.importProfile.Name = "importProfile";
            this.importProfile.Size = new System.Drawing.Size(60, 23);
            this.importProfile.TabIndex = 4;
            this.importProfile.Text = "Import";
            this.importProfile.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.importProfile.Click += new System.EventHandler(this.importProfile_Click);
            // 
            // exportProfile
            // 
            this.exportProfile.ColorTable = office2010Blue1;
            this.exportProfile.Location = new System.Drawing.Point(292, 18);
            this.exportProfile.Name = "exportProfile";
            this.exportProfile.Size = new System.Drawing.Size(60, 23);
            this.exportProfile.TabIndex = 3;
            this.exportProfile.Text = "Export";
            this.exportProfile.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.exportProfile.Click += new System.EventHandler(this.exportProfile_Click);
            // 
            // delProfile
            // 
            this.delProfile.ColorTable = office2010Blue1;
            this.delProfile.Location = new System.Drawing.Point(226, 18);
            this.delProfile.Name = "delProfile";
            this.delProfile.Size = new System.Drawing.Size(60, 23);
            this.delProfile.TabIndex = 2;
            this.delProfile.Text = "Delete";
            this.delProfile.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.delProfile.Click += new System.EventHandler(this.delProfile_Click);
            // 
            // newProfile
            // 
            this.newProfile.ColorTable = office2010Blue1;
            this.newProfile.Location = new System.Drawing.Point(161, 18);
            this.newProfile.Name = "newProfile";
            this.newProfile.Size = new System.Drawing.Size(60, 23);
            this.newProfile.TabIndex = 1;
            this.newProfile.Text = "&New...";
            this.newProfile.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.newProfile.Click += new System.EventHandler(this.newProfile_Click);
            // 
            // profiles
            // 
            this.profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profiles.ItemHeight = 20;
            this.profiles.Location = new System.Drawing.Point(10, 16);
            this.profiles.MaxDropDownItems = 5;
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(146, 28);
            this.profiles.TabIndex = 0;
            this.profiles.SelectedIndexChanged += new System.EventHandler(this.profiles_SelectedIndexChanged);
            // 
            // showWelcome
            // 
            this.showWelcome.Location = new System.Drawing.Point(224, 27);
            this.showWelcome.Name = "showWelcome";
            this.showWelcome.Size = new System.Drawing.Size(293, 23);
            this.showWelcome.TabIndex = 26;
            this.showWelcome.Text = "Show Welcome Screen";
            this.showWelcome.CheckedChanged += new System.EventHandler(this.showWelcome_CheckedChanged);
            // 
            // opacity
            // 
            this.opacity.AutoSize = false;
            this.opacity.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.opacity.Location = new System.Drawing.Point(305, 296);
            this.opacity.Maximum = 100;
            this.opacity.Minimum = 10;
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(332, 19);
            this.opacity.TabIndex = 22;
            this.opacity.TickFrequency = 0;
            this.opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.opacity.Value = 100;
            this.opacity.Scroll += new System.EventHandler(this.opacity_Scroll);
            // 
            // alwaysTop
            // 
            this.alwaysTop.Location = new System.Drawing.Point(224, 85);
            this.alwaysTop.Name = "alwaysTop";
            this.alwaysTop.Size = new System.Drawing.Size(290, 23);
            this.alwaysTop.TabIndex = 3;
            this.alwaysTop.Text = "Use Smart Always on Top";
            this.alwaysTop.CheckedChanged += new System.EventHandler(this.alwaysTop_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filters);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // filters
            // 
            this.filters.CheckOnClick = true;
            this.filters.IntegralHeight = false;
            this.filters.Location = new System.Drawing.Point(7, 18);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(186, 259);
            this.filters.TabIndex = 0;
            this.filters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnFilterCheck);
            // 
            // opacityLabel
            // 
            this.opacityLabel.Location = new System.Drawing.Point(211, 294);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(94, 19);
            this.opacityLabel.TabIndex = 23;
            this.opacityLabel.Text = "Opacity: 100%";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(221, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 59;
            this.label9.Text = "Default Client Priority:";
            // 
            // moreOptTab
            // 
            this.moreOptTab.Controls.Add(this.preAOSstatbar);
            this.moreOptTab.Controls.Add(this.negotiate);
            this.moreOptTab.Controls.Add(this.setLTHilight);
            this.moreOptTab.Controls.Add(this.lthilight);
            this.moreOptTab.Controls.Add(this.filterSnoop);
            this.moreOptTab.Controls.Add(this.corpseRange);
            this.moreOptTab.Controls.Add(this.incomingCorpse);
            this.moreOptTab.Controls.Add(this.incomingMob);
            this.moreOptTab.Controls.Add(this.setHarmHue);
            this.moreOptTab.Controls.Add(this.setNeuHue);
            this.moreOptTab.Controls.Add(this.lblHarmHue);
            this.moreOptTab.Controls.Add(this.lblNeuHue);
            this.moreOptTab.Controls.Add(this.lblBeneHue);
            this.moreOptTab.Controls.Add(this.label4);
            this.moreOptTab.Controls.Add(this.lblWarnHue);
            this.moreOptTab.Controls.Add(this.lblMsgHue);
            this.moreOptTab.Controls.Add(this.lblExHue);
            this.moreOptTab.Controls.Add(this.label3);
            this.moreOptTab.Controls.Add(this.setBeneHue);
            this.moreOptTab.Controls.Add(this.setSpeechHue);
            this.moreOptTab.Controls.Add(this.setWarnHue);
            this.moreOptTab.Controls.Add(this.setMsgHue);
            this.moreOptTab.Controls.Add(this.setExHue);
            this.moreOptTab.Controls.Add(this.autoStackRes);
            this.moreOptTab.Controls.Add(this.queueTargets);
            this.moreOptTab.Controls.Add(this.spamFilter);
            this.moreOptTab.Controls.Add(this.openCorpses);
            this.moreOptTab.Controls.Add(this.blockDis);
            this.moreOptTab.Controls.Add(this.txtSpellFormat);
            this.moreOptTab.Controls.Add(this.chkForceSpellHue);
            this.moreOptTab.Controls.Add(this.chkForceSpeechHue);
            this.moreOptTab.Location = new System.Drawing.Point(4, 46);
            this.moreOptTab.Name = "moreOptTab";
            this.moreOptTab.Size = new System.Drawing.Size(640, 323);
            this.moreOptTab.TabIndex = 5;
            this.moreOptTab.Text = "Options";
            // 
            // preAOSstatbar
            // 
            this.preAOSstatbar.Location = new System.Drawing.Point(245, 15);
            this.preAOSstatbar.Name = "preAOSstatbar";
            this.preAOSstatbar.Size = new System.Drawing.Size(228, 23);
            this.preAOSstatbar.TabIndex = 57;
            this.preAOSstatbar.Text = "Use Pre-AOS status window";
            this.preAOSstatbar.CheckedChanged += new System.EventHandler(this.preAOSstatbar_CheckedChanged);
            // 
            // negotiate
            // 
            this.negotiate.Location = new System.Drawing.Point(245, 215);
            this.negotiate.Name = "negotiate";
            this.negotiate.Size = new System.Drawing.Size(269, 23);
            this.negotiate.TabIndex = 56;
            this.negotiate.Text = "Negotiate features with server";
            this.negotiate.CheckedChanged += new System.EventHandler(this.negotiate_CheckedChanged);
            // 
            // setLTHilight
            // 
            this.setLTHilight.ColorTable = office2010Blue1;
            this.setLTHilight.Location = new System.Drawing.Point(171, 125);
            this.setLTHilight.Name = "setLTHilight";
            this.setLTHilight.Size = new System.Drawing.Size(38, 23);
            this.setLTHilight.TabIndex = 51;
            this.setLTHilight.Text = "Set";
            this.setLTHilight.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setLTHilight.Click += new System.EventHandler(this.setLTHilight_Click);
            // 
            // lthilight
            // 
            this.lthilight.Location = new System.Drawing.Point(8, 128);
            this.lthilight.Name = "lthilight";
            this.lthilight.Size = new System.Drawing.Size(158, 23);
            this.lthilight.TabIndex = 50;
            this.lthilight.Text = "Last Target Highlight:";
            this.lthilight.CheckedChanged += new System.EventHandler(this.lthilight_CheckedChanged);
            // 
            // filterSnoop
            // 
            this.filterSnoop.Location = new System.Drawing.Point(245, 165);
            this.filterSnoop.Name = "filterSnoop";
            this.filterSnoop.Size = new System.Drawing.Size(276, 23);
            this.filterSnoop.TabIndex = 49;
            this.filterSnoop.Text = "Filter Snooping Messages";
            this.filterSnoop.CheckedChanged += new System.EventHandler(this.filterSnoop_CheckedChanged);
            // 
            // corpseRange
            // 
            this.corpseRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.corpseRange.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.corpseRange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.corpseRange.Location = new System.Drawing.Point(426, 115);
            this.corpseRange.Name = "corpseRange";
            this.corpseRange.Padding = new System.Windows.Forms.Padding(1);
            this.corpseRange.Size = new System.Drawing.Size(29, 22);
            this.corpseRange.TabIndex = 23;
            this.corpseRange.TextChanged += new System.EventHandler(this.corpseRange_TextChanged);
            // 
            // incomingCorpse
            // 
            this.incomingCorpse.Location = new System.Drawing.Point(245, 240);
            this.incomingCorpse.Name = "incomingCorpse";
            this.incomingCorpse.Size = new System.Drawing.Size(271, 23);
            this.incomingCorpse.TabIndex = 48;
            this.incomingCorpse.Text = "Show Names of New/Incoming Corpses";
            this.incomingCorpse.CheckedChanged += new System.EventHandler(this.incomingCorpse_CheckedChanged);
            // 
            // incomingMob
            // 
            this.incomingMob.Location = new System.Drawing.Point(245, 190);
            this.incomingMob.Name = "incomingMob";
            this.incomingMob.Size = new System.Drawing.Size(293, 23);
            this.incomingMob.TabIndex = 47;
            this.incomingMob.Text = "Show Names of Incoming People/Creatures";
            this.incomingMob.CheckedChanged += new System.EventHandler(this.incomingMob_CheckedChanged);
            // 
            // setHarmHue
            // 
            this.setHarmHue.ColorTable = office2010Blue1;
            this.setHarmHue.Enabled = false;
            this.setHarmHue.Location = new System.Drawing.Point(95, 204);
            this.setHarmHue.Name = "setHarmHue";
            this.setHarmHue.Size = new System.Drawing.Size(38, 23);
            this.setHarmHue.TabIndex = 42;
            this.setHarmHue.Text = "Set";
            this.setHarmHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setHarmHue.Click += new System.EventHandler(this.setHarmHue_Click);
            // 
            // setNeuHue
            // 
            this.setNeuHue.ColorTable = office2010Blue1;
            this.setNeuHue.Enabled = false;
            this.setNeuHue.Location = new System.Drawing.Point(164, 204);
            this.setNeuHue.Name = "setNeuHue";
            this.setNeuHue.Size = new System.Drawing.Size(38, 23);
            this.setNeuHue.TabIndex = 43;
            this.setNeuHue.Text = "Set";
            this.setNeuHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setNeuHue.Click += new System.EventHandler(this.setNeuHue_Click);
            // 
            // lblHarmHue
            // 
            this.lblHarmHue.Location = new System.Drawing.Point(93, 185);
            this.lblHarmHue.Name = "lblHarmHue";
            this.lblHarmHue.Size = new System.Drawing.Size(53, 16);
            this.lblHarmHue.TabIndex = 46;
            this.lblHarmHue.Text = "Harmful";
            // 
            // lblNeuHue
            // 
            this.lblNeuHue.Location = new System.Drawing.Point(162, 185);
            this.lblNeuHue.Name = "lblNeuHue";
            this.lblNeuHue.Size = new System.Drawing.Size(50, 16);
            this.lblNeuHue.TabIndex = 45;
            this.lblNeuHue.Text = "Neutral";
            // 
            // lblBeneHue
            // 
            this.lblBeneHue.Location = new System.Drawing.Point(21, 185);
            this.lblBeneHue.Name = "lblBeneHue";
            this.lblBeneHue.Size = new System.Drawing.Size(65, 16);
            this.lblBeneHue.TabIndex = 44;
            this.lblBeneHue.Text = "Beneficial";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(461, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "tiles";
            // 
            // lblWarnHue
            // 
            this.lblWarnHue.Location = new System.Drawing.Point(8, 71);
            this.lblWarnHue.Name = "lblWarnHue";
            this.lblWarnHue.Size = new System.Drawing.Size(144, 19);
            this.lblWarnHue.TabIndex = 16;
            this.lblWarnHue.Text = "Warning Message Hue";
            // 
            // lblMsgHue
            // 
            this.lblMsgHue.Location = new System.Drawing.Point(8, 43);
            this.lblMsgHue.Name = "lblMsgHue";
            this.lblMsgHue.Size = new System.Drawing.Size(139, 19);
            this.lblMsgHue.TabIndex = 15;
            this.lblMsgHue.Text = "Razor Message Hue";
            // 
            // lblExHue
            // 
            this.lblExHue.Location = new System.Drawing.Point(8, 15);
            this.lblExHue.Name = "lblExHue";
            this.lblExHue.Size = new System.Drawing.Size(144, 19);
            this.lblExHue.TabIndex = 14;
            this.lblExHue.Text = "Search Exemption Hue";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spell Format:";
            // 
            // setBeneHue
            // 
            this.setBeneHue.ColorTable = office2010Blue1;
            this.setBeneHue.Enabled = false;
            this.setBeneHue.Location = new System.Drawing.Point(29, 204);
            this.setBeneHue.Name = "setBeneHue";
            this.setBeneHue.Size = new System.Drawing.Size(39, 23);
            this.setBeneHue.TabIndex = 41;
            this.setBeneHue.Text = "Set";
            this.setBeneHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setBeneHue.Click += new System.EventHandler(this.setBeneHue_Click);
            // 
            // setSpeechHue
            // 
            this.setSpeechHue.ColorTable = office2010Blue1;
            this.setSpeechHue.Location = new System.Drawing.Point(171, 97);
            this.setSpeechHue.Name = "setSpeechHue";
            this.setSpeechHue.Size = new System.Drawing.Size(38, 23);
            this.setSpeechHue.TabIndex = 40;
            this.setSpeechHue.Text = "Set";
            this.setSpeechHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setSpeechHue.Click += new System.EventHandler(this.setSpeechHue_Click);
            // 
            // setWarnHue
            // 
            this.setWarnHue.ColorTable = office2010Blue1;
            this.setWarnHue.Location = new System.Drawing.Point(171, 69);
            this.setWarnHue.Name = "setWarnHue";
            this.setWarnHue.Size = new System.Drawing.Size(38, 23);
            this.setWarnHue.TabIndex = 39;
            this.setWarnHue.Text = "Set";
            this.setWarnHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setWarnHue.Click += new System.EventHandler(this.setWarnHue_Click);
            // 
            // setMsgHue
            // 
            this.setMsgHue.ColorTable = office2010Blue1;
            this.setMsgHue.Location = new System.Drawing.Point(171, 41);
            this.setMsgHue.Name = "setMsgHue";
            this.setMsgHue.Size = new System.Drawing.Size(38, 23);
            this.setMsgHue.TabIndex = 38;
            this.setMsgHue.Text = "Set";
            this.setMsgHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setMsgHue.Click += new System.EventHandler(this.setMsgHue_Click);
            // 
            // setExHue
            // 
            this.setExHue.ColorTable = office2010Blue1;
            this.setExHue.Location = new System.Drawing.Point(171, 13);
            this.setExHue.Name = "setExHue";
            this.setExHue.Size = new System.Drawing.Size(38, 23);
            this.setExHue.TabIndex = 37;
            this.setExHue.Text = "Set";
            this.setExHue.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setExHue.Click += new System.EventHandler(this.setExHue_Click);
            // 
            // autoStackRes
            // 
            this.autoStackRes.Location = new System.Drawing.Point(245, 90);
            this.autoStackRes.Name = "autoStackRes";
            this.autoStackRes.Size = new System.Drawing.Size(273, 23);
            this.autoStackRes.TabIndex = 35;
            this.autoStackRes.Text = "Auto-Stack Ore/Fish/Logs at Feet";
            this.autoStackRes.CheckedChanged += new System.EventHandler(this.autoStackRes_CheckedChanged);
            // 
            // queueTargets
            // 
            this.queueTargets.Location = new System.Drawing.Point(245, 40);
            this.queueTargets.Name = "queueTargets";
            this.queueTargets.Size = new System.Drawing.Size(273, 23);
            this.queueTargets.TabIndex = 34;
            this.queueTargets.Text = "Queue LastTarget and TargetSelf";
            this.queueTargets.CheckedChanged += new System.EventHandler(this.queueTargets_CheckedChanged);
            // 
            // spamFilter
            // 
            this.spamFilter.Location = new System.Drawing.Point(245, 140);
            this.spamFilter.Name = "spamFilter";
            this.spamFilter.Size = new System.Drawing.Size(273, 23);
            this.spamFilter.TabIndex = 26;
            this.spamFilter.Text = "Filter repeating system messages";
            this.spamFilter.CheckedChanged += new System.EventHandler(this.spamFilter_CheckedChanged);
            // 
            // openCorpses
            // 
            this.openCorpses.Location = new System.Drawing.Point(245, 115);
            this.openCorpses.Name = "openCorpses";
            this.openCorpses.Size = new System.Drawing.Size(187, 23);
            this.openCorpses.TabIndex = 22;
            this.openCorpses.Text = "Open new corpses within";
            this.openCorpses.CheckedChanged += new System.EventHandler(this.openCorpses_CheckedChanged);
            // 
            // blockDis
            // 
            this.blockDis.Location = new System.Drawing.Point(245, 65);
            this.blockDis.Name = "blockDis";
            this.blockDis.Size = new System.Drawing.Size(221, 23);
            this.blockDis.TabIndex = 55;
            this.blockDis.Text = "Block dismount in war mode";
            this.blockDis.CheckedChanged += new System.EventHandler(this.blockDis_CheckedChanged);
            // 
            // txtSpellFormat
            // 
            this.txtSpellFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtSpellFormat.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtSpellFormat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.txtSpellFormat.Location = new System.Drawing.Point(97, 244);
            this.txtSpellFormat.Name = "txtSpellFormat";
            this.txtSpellFormat.Padding = new System.Windows.Forms.Padding(1);
            this.txtSpellFormat.Size = new System.Drawing.Size(128, 22);
            this.txtSpellFormat.TabIndex = 5;
            this.txtSpellFormat.TextChanged += new System.EventHandler(this.txtSpellFormat_TextChanged);
            // 
            // chkForceSpellHue
            // 
            this.chkForceSpellHue.Location = new System.Drawing.Point(8, 156);
            this.chkForceSpellHue.Name = "chkForceSpellHue";
            this.chkForceSpellHue.Size = new System.Drawing.Size(153, 23);
            this.chkForceSpellHue.TabIndex = 2;
            this.chkForceSpellHue.Text = "Override Spell Hues:";
            this.chkForceSpellHue.CheckedChanged += new System.EventHandler(this.chkForceSpellHue_CheckedChanged);
            // 
            // chkForceSpeechHue
            // 
            this.chkForceSpeechHue.Location = new System.Drawing.Point(8, 100);
            this.chkForceSpeechHue.Name = "chkForceSpeechHue";
            this.chkForceSpeechHue.Size = new System.Drawing.Size(158, 23);
            this.chkForceSpeechHue.TabIndex = 0;
            this.chkForceSpeechHue.Text = "Override Speech Hue";
            this.chkForceSpeechHue.CheckedChanged += new System.EventHandler(this.chkForceSpeechHue_CheckedChanged);
            // 
            // moreMoreOptTab
            // 
            this.moreMoreOptTab.Controls.Add(this.msglvl);
            this.moreMoreOptTab.Controls.Add(this.forceSizeX);
            this.moreMoreOptTab.Controls.Add(this.forceSizeY);
            this.moreMoreOptTab.Controls.Add(this.healthFmt);
            this.moreMoreOptTab.Controls.Add(this.label10);
            this.moreMoreOptTab.Controls.Add(this.label17);
            this.moreMoreOptTab.Controls.Add(this.label5);
            this.moreMoreOptTab.Controls.Add(this.label8);
            this.moreMoreOptTab.Controls.Add(this.label6);
            this.moreMoreOptTab.Controls.Add(this.label18);
            this.moreMoreOptTab.Controls.Add(this.showHealthOH);
            this.moreMoreOptTab.Controls.Add(this.blockHealPoison);
            this.moreMoreOptTab.Controls.Add(this.ltRange);
            this.moreMoreOptTab.Controls.Add(this.potionEquip);
            this.moreMoreOptTab.Controls.Add(this.txtObjDelay);
            this.moreMoreOptTab.Controls.Add(this.QueueActions);
            this.moreMoreOptTab.Controls.Add(this.spellUnequip);
            this.moreMoreOptTab.Controls.Add(this.autoOpenDoors);
            this.moreMoreOptTab.Controls.Add(this.alwaysStealth);
            this.moreMoreOptTab.Controls.Add(this.autoFriend);
            this.moreMoreOptTab.Controls.Add(this.chkStealth);
            this.moreMoreOptTab.Controls.Add(this.rememberPwds);
            this.moreMoreOptTab.Controls.Add(this.showtargtext);
            this.moreMoreOptTab.Controls.Add(this.logPackets);
            this.moreMoreOptTab.Controls.Add(this.rangeCheckLT);
            this.moreMoreOptTab.Controls.Add(this.actionStatusMsg);
            this.moreMoreOptTab.Controls.Add(this.smartLT);
            this.moreMoreOptTab.Controls.Add(this.gameSize);
            this.moreMoreOptTab.Controls.Add(this.chkPartyOverhead);
            this.moreMoreOptTab.Location = new System.Drawing.Point(4, 46);
            this.moreMoreOptTab.Name = "moreMoreOptTab";
            this.moreMoreOptTab.Size = new System.Drawing.Size(640, 323);
            this.moreMoreOptTab.TabIndex = 10;
            this.moreMoreOptTab.Text = "More Options";
            // 
            // msglvl
            // 
            this.msglvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.msglvl.Items.AddRange(new object[] {
            "Show All",
            "Warnings & Errors",
            "Errors Only",
            "None"});
            this.msglvl.Location = new System.Drawing.Point(142, 243);
            this.msglvl.Name = "msglvl";
            this.msglvl.Size = new System.Drawing.Size(105, 28);
            this.msglvl.TabIndex = 60;
            this.msglvl.SelectedIndexChanged += new System.EventHandler(this.msglvl_SelectedIndexChanged);
            // 
            // forceSizeX
            // 
            this.forceSizeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.forceSizeX.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.forceSizeX.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.forceSizeX.Location = new System.Drawing.Point(450, 215);
            this.forceSizeX.Name = "forceSizeX";
            this.forceSizeX.Padding = new System.Windows.Forms.Padding(1);
            this.forceSizeX.Size = new System.Drawing.Size(36, 22);
            this.forceSizeX.TabIndex = 63;
            this.forceSizeX.TextChanged += new System.EventHandler(this.forceSizeX_TextChanged);
            // 
            // forceSizeY
            // 
            this.forceSizeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.forceSizeY.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.forceSizeY.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.forceSizeY.Location = new System.Drawing.Point(500, 215);
            this.forceSizeY.Name = "forceSizeY";
            this.forceSizeY.Padding = new System.Windows.Forms.Padding(1);
            this.forceSizeY.Size = new System.Drawing.Size(36, 22);
            this.forceSizeY.TabIndex = 64;
            this.forceSizeY.TextChanged += new System.EventHandler(this.forceSizeY_TextChanged);
            // 
            // healthFmt
            // 
            this.healthFmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.healthFmt.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.healthFmt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.healthFmt.Location = new System.Drawing.Point(191, 183);
            this.healthFmt.Name = "healthFmt";
            this.healthFmt.Padding = new System.Windows.Forms.Padding(1);
            this.healthFmt.Size = new System.Drawing.Size(55, 22);
            this.healthFmt.TabIndex = 71;
            this.healthFmt.TextChanged += new System.EventHandler(this.healthFmt_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Health Format:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 21);
            this.label17.TabIndex = 59;
            this.label17.Text = "Razor messages:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Object delay:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(235, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "tiles";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(237, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "ms";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(447, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 21);
            this.label18.TabIndex = 66;
            this.label18.Text = "x";
            // 
            // showHealthOH
            // 
            this.showHealthOH.Location = new System.Drawing.Point(8, 165);
            this.showHealthOH.Name = "showHealthOH";
            this.showHealthOH.Size = new System.Drawing.Size(257, 23);
            this.showHealthOH.TabIndex = 69;
            this.showHealthOH.Text = "Show health above people/creatures";
            this.showHealthOH.CheckedChanged += new System.EventHandler(this.showHealthOH_CheckedChanged);
            // 
            // blockHealPoison
            // 
            this.blockHealPoison.Location = new System.Drawing.Point(286, 190);
            this.blockHealPoison.Name = "blockHealPoison";
            this.blockHealPoison.Size = new System.Drawing.Size(257, 23);
            this.blockHealPoison.TabIndex = 68;
            this.blockHealPoison.Text = "Block heal if target is poisoned";
            this.blockHealPoison.CheckedChanged += new System.EventHandler(this.blockHealPoison_CheckedChanged);
            // 
            // ltRange
            // 
            this.ltRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.ltRange.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.ltRange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.ltRange.Location = new System.Drawing.Point(191, 114);
            this.ltRange.Name = "ltRange";
            this.ltRange.Padding = new System.Windows.Forms.Padding(1);
            this.ltRange.Size = new System.Drawing.Size(38, 22);
            this.ltRange.TabIndex = 41;
            this.ltRange.TextChanged += new System.EventHandler(this.ltRange_TextChanged);
            // 
            // potionEquip
            // 
            this.potionEquip.Location = new System.Drawing.Point(286, 165);
            this.potionEquip.Name = "potionEquip";
            this.potionEquip.Size = new System.Drawing.Size(257, 23);
            this.potionEquip.TabIndex = 67;
            this.potionEquip.Text = "Auto Un/Re-equip hands for potions";
            this.potionEquip.CheckedChanged += new System.EventHandler(this.potionEquip_CheckedChanged);
            // 
            // txtObjDelay
            // 
            this.txtObjDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtObjDelay.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtObjDelay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.txtObjDelay.Location = new System.Drawing.Point(191, 64);
            this.txtObjDelay.Name = "txtObjDelay";
            this.txtObjDelay.Padding = new System.Windows.Forms.Padding(1);
            this.txtObjDelay.Size = new System.Drawing.Size(38, 22);
            this.txtObjDelay.TabIndex = 37;
            this.txtObjDelay.TextChanged += new System.EventHandler(this.txtObjDelay_TextChanged);
            // 
            // QueueActions
            // 
            this.QueueActions.Location = new System.Drawing.Point(8, 40);
            this.QueueActions.Name = "QueueActions";
            this.QueueActions.Size = new System.Drawing.Size(254, 23);
            this.QueueActions.TabIndex = 34;
            this.QueueActions.Text = "Auto-Queue Object Delay actions ";
            this.QueueActions.CheckedChanged += new System.EventHandler(this.QueueActions_CheckedChanged);
            // 
            // spellUnequip
            // 
            this.spellUnequip.Location = new System.Drawing.Point(286, 140);
            this.spellUnequip.Name = "spellUnequip";
            this.spellUnequip.Size = new System.Drawing.Size(257, 23);
            this.spellUnequip.TabIndex = 39;
            this.spellUnequip.Text = "Auto Unequip hands before casting";
            this.spellUnequip.CheckedChanged += new System.EventHandler(this.spellUnequip_CheckedChanged);
            // 
            // autoOpenDoors
            // 
            this.autoOpenDoors.Location = new System.Drawing.Point(286, 115);
            this.autoOpenDoors.Name = "autoOpenDoors";
            this.autoOpenDoors.Size = new System.Drawing.Size(228, 23);
            this.autoOpenDoors.TabIndex = 58;
            this.autoOpenDoors.Text = "Automatically open doors";
            this.autoOpenDoors.CheckedChanged += new System.EventHandler(this.autoOpenDoors_CheckedChanged);
            // 
            // alwaysStealth
            // 
            this.alwaysStealth.Location = new System.Drawing.Point(286, 90);
            this.alwaysStealth.Name = "alwaysStealth";
            this.alwaysStealth.Size = new System.Drawing.Size(228, 23);
            this.alwaysStealth.TabIndex = 57;
            this.alwaysStealth.Text = "Always show stealth steps ";
            this.alwaysStealth.CheckedChanged += new System.EventHandler(this.alwaysStealth_CheckedChanged);
            // 
            // autoFriend
            // 
            this.autoFriend.Location = new System.Drawing.Point(286, 40);
            this.autoFriend.Name = "autoFriend";
            this.autoFriend.Size = new System.Drawing.Size(228, 23);
            this.autoFriend.TabIndex = 56;
            this.autoFriend.Text = "Treat party members as \'Friends\'";
            this.autoFriend.CheckedChanged += new System.EventHandler(this.autoFriend_CheckedChanged);
            // 
            // chkStealth
            // 
            this.chkStealth.Location = new System.Drawing.Point(286, 65);
            this.chkStealth.Name = "chkStealth";
            this.chkStealth.Size = new System.Drawing.Size(228, 23);
            this.chkStealth.TabIndex = 12;
            this.chkStealth.Text = "Count stealth steps";
            this.chkStealth.CheckedChanged += new System.EventHandler(this.chkStealth_CheckedChanged);
            // 
            // rememberPwds
            // 
            this.rememberPwds.Location = new System.Drawing.Point(286, 15);
            this.rememberPwds.Name = "rememberPwds";
            this.rememberPwds.Size = new System.Drawing.Size(228, 23);
            this.rememberPwds.TabIndex = 54;
            this.rememberPwds.Text = "Remember passwords ";
            this.rememberPwds.CheckedChanged += new System.EventHandler(this.rememberPwds_CheckedChanged);
            // 
            // showtargtext
            // 
            this.showtargtext.Location = new System.Drawing.Point(8, 140);
            this.showtargtext.Name = "showtargtext";
            this.showtargtext.Size = new System.Drawing.Size(228, 23);
            this.showtargtext.TabIndex = 53;
            this.showtargtext.Text = "Show target flag on single click";
            this.showtargtext.CheckedChanged += new System.EventHandler(this.showtargtext_CheckedChanged);
            // 
            // logPackets
            // 
            this.logPackets.Location = new System.Drawing.Point(286, 240);
            this.logPackets.Name = "logPackets";
            this.logPackets.Size = new System.Drawing.Size(223, 21);
            this.logPackets.TabIndex = 50;
            this.logPackets.Text = "Enable packet logging";
            this.logPackets.CheckedChanged += new System.EventHandler(this.logPackets_CheckedChanged);
            // 
            // rangeCheckLT
            // 
            this.rangeCheckLT.Location = new System.Drawing.Point(8, 115);
            this.rangeCheckLT.Name = "rangeCheckLT";
            this.rangeCheckLT.Size = new System.Drawing.Size(182, 23);
            this.rangeCheckLT.TabIndex = 40;
            this.rangeCheckLT.Text = "Range check Last Target:";
            this.rangeCheckLT.CheckedChanged += new System.EventHandler(this.rangeCheckLT_CheckedChanged);
            // 
            // actionStatusMsg
            // 
            this.actionStatusMsg.Location = new System.Drawing.Point(8, 15);
            this.actionStatusMsg.Name = "actionStatusMsg";
            this.actionStatusMsg.Size = new System.Drawing.Size(254, 23);
            this.actionStatusMsg.TabIndex = 38;
            this.actionStatusMsg.Text = "Show Action-Queue status messages";
            this.actionStatusMsg.CheckedChanged += new System.EventHandler(this.actionStatusMsg_CheckedChanged);
            // 
            // smartLT
            // 
            this.smartLT.Location = new System.Drawing.Point(8, 90);
            this.smartLT.Name = "smartLT";
            this.smartLT.Size = new System.Drawing.Size(223, 23);
            this.smartLT.TabIndex = 52;
            this.smartLT.Text = "Use smart last target";
            this.smartLT.CheckedChanged += new System.EventHandler(this.smartLT_CheckedChanged);
            // 
            // gameSize
            // 
            this.gameSize.Location = new System.Drawing.Point(286, 215);
            this.gameSize.Name = "gameSize";
            this.gameSize.Size = new System.Drawing.Size(137, 21);
            this.gameSize.TabIndex = 65;
            this.gameSize.Text = "Force Game Size:";
            this.gameSize.CheckedChanged += new System.EventHandler(this.gameSize_CheckedChanged);
            // 
            // chkPartyOverhead
            // 
            this.chkPartyOverhead.Location = new System.Drawing.Point(8, 211);
            this.chkPartyOverhead.Name = "chkPartyOverhead";
            this.chkPartyOverhead.Size = new System.Drawing.Size(269, 23);
            this.chkPartyOverhead.TabIndex = 72;
            this.chkPartyOverhead.Text = "Show mana/stam above party members";
            this.chkPartyOverhead.CheckedChanged += new System.EventHandler(this.chkPartyOverhead_CheckedChanged);
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.showNotoHue);
            this.displayTab.Controls.Add(this.warnNum);
            this.displayTab.Controls.Add(this.warnCount);
            this.displayTab.Controls.Add(this.excludePouches);
            this.displayTab.Controls.Add(this.highlightSpellReags);
            this.displayTab.Controls.Add(this.titlebarImages);
            this.displayTab.Controls.Add(this.checkNewConts);
            this.displayTab.Controls.Add(this.groupBox3);
            this.displayTab.Controls.Add(this.groupBox2);
            this.displayTab.Location = new System.Drawing.Point(4, 46);
            this.displayTab.Name = "displayTab";
            this.displayTab.Size = new System.Drawing.Size(640, 323);
            this.displayTab.TabIndex = 1;
            this.displayTab.Text = "Display/Counters";
            // 
            // showNotoHue
            // 
            this.showNotoHue.Location = new System.Drawing.Point(291, 227);
            this.showNotoHue.Name = "showNotoHue";
            this.showNotoHue.Size = new System.Drawing.Size(273, 23);
            this.showNotoHue.TabIndex = 47;
            this.showNotoHue.Text = "Show noto hue on {char} in TitleBar";
            this.showNotoHue.CheckedChanged += new System.EventHandler(this.showNotoHue_CheckedChanged);
            // 
            // warnNum
            // 
            this.warnNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.warnNum.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.warnNum.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.warnNum.Location = new System.Drawing.Point(497, 273);
            this.warnNum.Name = "warnNum";
            this.warnNum.Padding = new System.Windows.Forms.Padding(1);
            this.warnNum.Size = new System.Drawing.Size(24, 22);
            this.warnNum.TabIndex = 46;
            this.warnNum.TextChanged += new System.EventHandler(this.warnNum_TextChanged);
            // 
            // warnCount
            // 
            this.warnCount.Location = new System.Drawing.Point(291, 273);
            this.warnCount.Name = "warnCount";
            this.warnCount.Size = new System.Drawing.Size(213, 22);
            this.warnCount.TabIndex = 45;
            this.warnCount.Text = "Warn when a counter is below:";
            this.warnCount.CheckedChanged += new System.EventHandler(this.warnCount_CheckedChanged);
            // 
            // excludePouches
            // 
            this.excludePouches.Location = new System.Drawing.Point(18, 253);
            this.excludePouches.Name = "excludePouches";
            this.excludePouches.Size = new System.Drawing.Size(230, 23);
            this.excludePouches.TabIndex = 14;
            this.excludePouches.Text = "Never auto-search pouches";
            this.excludePouches.CheckedChanged += new System.EventHandler(this.excludePouches_CheckedChanged);
            // 
            // highlightSpellReags
            // 
            this.highlightSpellReags.Location = new System.Drawing.Point(291, 204);
            this.highlightSpellReags.Name = "highlightSpellReags";
            this.highlightSpellReags.Size = new System.Drawing.Size(240, 23);
            this.highlightSpellReags.TabIndex = 13;
            this.highlightSpellReags.Text = "Highlight Spell Reagents on Cast";
            this.highlightSpellReags.CheckedChanged += new System.EventHandler(this.highlightSpellReags_CheckedChanged);
            // 
            // titlebarImages
            // 
            this.titlebarImages.Location = new System.Drawing.Point(291, 250);
            this.titlebarImages.Name = "titlebarImages";
            this.titlebarImages.Size = new System.Drawing.Size(240, 23);
            this.titlebarImages.TabIndex = 12;
            this.titlebarImages.Text = "Show Images with Counters";
            this.titlebarImages.CheckedChanged += new System.EventHandler(this.titlebarImages_CheckedChanged);
            // 
            // checkNewConts
            // 
            this.checkNewConts.Location = new System.Drawing.Point(18, 224);
            this.checkNewConts.Name = "checkNewConts";
            this.checkNewConts.Size = new System.Drawing.Size(240, 23);
            this.checkNewConts.TabIndex = 9;
            this.checkNewConts.Text = "Auto search new containers";
            this.checkNewConts.CheckedChanged += new System.EventHandler(this.checkNewConts_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.titleStr);
            this.groupBox3.Controls.Add(this.showInBar);
            this.groupBox3.Location = new System.Drawing.Point(281, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Title Bar Display";
            // 
            // titleStr
            // 
            this.titleStr.Location = new System.Drawing.Point(10, 42);
            this.titleStr.Multiline = true;
            this.titleStr.Name = "titleStr";
            this.titleStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.titleStr.Size = new System.Drawing.Size(334, 110);
            this.titleStr.TabIndex = 4;
            this.titleStr.TextChanged += new System.EventHandler(this.titleStr_TextChanged);
            // 
            // showInBar
            // 
            this.showInBar.Location = new System.Drawing.Point(10, 18);
            this.showInBar.Name = "showInBar";
            this.showInBar.Size = new System.Drawing.Size(216, 23);
            this.showInBar.TabIndex = 3;
            this.showInBar.Text = "Show this in the UO title bar:";
            this.showInBar.CheckedChanged += new System.EventHandler(this.showInBar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.counters);
            this.groupBox2.Controls.Add(this.delCounter);
            this.groupBox2.Controls.Add(this.addCounter);
            this.groupBox2.Controls.Add(this.recount);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counters";
            // 
            // counters
            // 
            this.counters.CheckBoxes = true;
            this.counters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cntName,
            this.cntCount});
            this.counters.GridLines = true;
            this.counters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.counters.LabelWrap = false;
            this.counters.Location = new System.Drawing.Point(10, 17);
            this.counters.MultiSelect = false;
            this.counters.Name = "counters";
            this.counters.Size = new System.Drawing.Size(216, 125);
            this.counters.TabIndex = 11;
            this.counters.UseCompatibleStateImageBehavior = false;
            this.counters.View = System.Windows.Forms.View.Details;
            this.counters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.counters_ItemCheck);
            // 
            // cntName
            // 
            this.cntName.Text = "Name (Format)";
            this.cntName.Width = 119;
            // 
            // cntCount
            // 
            this.cntCount.Text = "Count";
            this.cntCount.Width = 40;
            // 
            // delCounter
            // 
            this.delCounter.ColorTable = office2010Blue1;
            this.delCounter.Location = new System.Drawing.Point(77, 154);
            this.delCounter.Name = "delCounter";
            this.delCounter.Size = new System.Drawing.Size(72, 23);
            this.delCounter.TabIndex = 4;
            this.delCounter.Text = "Del/Edit";
            this.delCounter.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.delCounter.Click += new System.EventHandler(this.delCounter_Click);
            // 
            // addCounter
            // 
            this.addCounter.ColorTable = office2010Blue1;
            this.addCounter.Location = new System.Drawing.Point(10, 154);
            this.addCounter.Name = "addCounter";
            this.addCounter.Size = new System.Drawing.Size(62, 23);
            this.addCounter.TabIndex = 3;
            this.addCounter.Text = "Add...";
            this.addCounter.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.addCounter.Click += new System.EventHandler(this.addCounter_Click);
            // 
            // recount
            // 
            this.recount.ColorTable = office2010Blue1;
            this.recount.Location = new System.Drawing.Point(154, 154);
            this.recount.Name = "recount";
            this.recount.Size = new System.Drawing.Size(72, 23);
            this.recount.TabIndex = 2;
            this.recount.Text = "Recount";
            this.recount.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.recount.Click += new System.EventHandler(this.recount_Click);
            // 
            // dressTab
            // 
            this.dressTab.Controls.Add(this.groupBox6);
            this.dressTab.Controls.Add(this.groupBox5);
            this.dressTab.Location = new System.Drawing.Point(4, 46);
            this.dressTab.Name = "dressTab";
            this.dressTab.Size = new System.Drawing.Size(640, 323);
            this.dressTab.TabIndex = 3;
            this.dressTab.Text = "Arm/Dress";
            this.dressTab.Click += new System.EventHandler(this.dressTab_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clearDress);
            this.groupBox6.Controls.Add(this.dressDelSel);
            this.groupBox6.Controls.Add(this.undressBag);
            this.groupBox6.Controls.Add(this.undressList);
            this.groupBox6.Controls.Add(this.dressUseCur);
            this.groupBox6.Controls.Add(this.targItem);
            this.groupBox6.Controls.Add(this.dressItems);
            this.groupBox6.Controls.Add(this.dressNow);
            this.groupBox6.Location = new System.Drawing.Point(269, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(362, 296);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Arm/Dress Items";
            // 
            // clearDress
            // 
            this.clearDress.ColorTable = office2010Blue1;
            this.clearDress.Location = new System.Drawing.Point(192, 129);
            this.clearDress.Name = "clearDress";
            this.clearDress.Size = new System.Drawing.Size(164, 23);
            this.clearDress.TabIndex = 13;
            this.clearDress.Text = "Clear List";
            this.clearDress.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.clearDress.Click += new System.EventHandler(this.clearDress_Click);
            // 
            // dressDelSel
            // 
            this.dressDelSel.ColorTable = office2010Blue1;
            this.dressDelSel.Location = new System.Drawing.Point(192, 101);
            this.dressDelSel.Name = "dressDelSel";
            this.dressDelSel.Size = new System.Drawing.Size(164, 23);
            this.dressDelSel.TabIndex = 12;
            this.dressDelSel.Text = "Remove";
            this.dressDelSel.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.dressDelSel.Click += new System.EventHandler(this.dressDelSel_Click);
            // 
            // undressBag
            // 
            this.undressBag.ColorTable = office2010Blue1;
            this.undressBag.Location = new System.Drawing.Point(192, 179);
            this.undressBag.Name = "undressBag";
            this.undressBag.Size = new System.Drawing.Size(164, 39);
            this.undressBag.TabIndex = 11;
            this.undressBag.Text = "Change Undress Bag";
            this.undressBag.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.undressBag.Click += new System.EventHandler(this.undressBag_Click);
            // 
            // undressList
            // 
            this.undressList.ColorTable = office2010Blue1;
            this.undressList.Location = new System.Drawing.Point(291, 16);
            this.undressList.Name = "undressList";
            this.undressList.Size = new System.Drawing.Size(65, 23);
            this.undressList.TabIndex = 10;
            this.undressList.Text = "Undress";
            this.undressList.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.undressList.Click += new System.EventHandler(this.undressList_Click);
            // 
            // dressUseCur
            // 
            this.dressUseCur.ColorTable = office2010Blue1;
            this.dressUseCur.Location = new System.Drawing.Point(192, 74);
            this.dressUseCur.Name = "dressUseCur";
            this.dressUseCur.Size = new System.Drawing.Size(164, 23);
            this.dressUseCur.TabIndex = 9;
            this.dressUseCur.Text = "Add Current";
            this.dressUseCur.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.dressUseCur.Click += new System.EventHandler(this.dressUseCur_Click);
            // 
            // targItem
            // 
            this.targItem.ColorTable = office2010Blue1;
            this.targItem.Location = new System.Drawing.Point(192, 46);
            this.targItem.Name = "targItem";
            this.targItem.Size = new System.Drawing.Size(164, 23);
            this.targItem.TabIndex = 7;
            this.targItem.Text = "Add (Target)";
            this.targItem.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.targItem.Click += new System.EventHandler(this.targItem_Click);
            // 
            // dressItems
            // 
            this.dressItems.IntegralHeight = false;
            this.dressItems.ItemHeight = 16;
            this.dressItems.Location = new System.Drawing.Point(10, 16);
            this.dressItems.Name = "dressItems";
            this.dressItems.Size = new System.Drawing.Size(175, 274);
            this.dressItems.TabIndex = 6;
            this.dressItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dressItems_KeyDown);
            this.dressItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dressItems_MouseDown);
            // 
            // dressNow
            // 
            this.dressNow.ColorTable = office2010Blue1;
            this.dressNow.Location = new System.Drawing.Point(192, 16);
            this.dressNow.Name = "dressNow";
            this.dressNow.Size = new System.Drawing.Size(65, 23);
            this.dressNow.TabIndex = 6;
            this.dressNow.Text = "Dress";
            this.dressNow.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.dressNow.Click += new System.EventHandler(this.dressNow_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.removeDress);
            this.groupBox5.Controls.Add(this.addDress);
            this.groupBox5.Controls.Add(this.dressList);
            this.groupBox5.Controls.Add(this.undressConflicts);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 296);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arm/Dress Selection";
            // 
            // removeDress
            // 
            this.removeDress.ColorTable = office2010Blue1;
            this.removeDress.Location = new System.Drawing.Point(86, 238);
            this.removeDress.Name = "removeDress";
            this.removeDress.Size = new System.Drawing.Size(72, 23);
            this.removeDress.TabIndex = 5;
            this.removeDress.Text = "Remove";
            this.removeDress.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.removeDress.Click += new System.EventHandler(this.removeDress_Click);
            // 
            // addDress
            // 
            this.addDress.ColorTable = office2010Blue1;
            this.addDress.Location = new System.Drawing.Point(10, 238);
            this.addDress.Name = "addDress";
            this.addDress.Size = new System.Drawing.Size(72, 23);
            this.addDress.TabIndex = 4;
            this.addDress.Text = "Add...";
            this.addDress.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.addDress.Click += new System.EventHandler(this.addDress_Click);
            // 
            // dressList
            // 
            this.dressList.IntegralHeight = false;
            this.dressList.ItemHeight = 16;
            this.dressList.Location = new System.Drawing.Point(10, 16);
            this.dressList.Name = "dressList";
            this.dressList.Size = new System.Drawing.Size(239, 216);
            this.dressList.TabIndex = 3;
            this.dressList.SelectedIndexChanged += new System.EventHandler(this.dressList_SelectedIndexChanged);
            // 
            // undressConflicts
            // 
            this.undressConflicts.Location = new System.Drawing.Point(0, 267);
            this.undressConflicts.Name = "undressConflicts";
            this.undressConflicts.Size = new System.Drawing.Size(249, 23);
            this.undressConflicts.TabIndex = 6;
            this.undressConflicts.Text = "Automatically move conflicting items";
            this.undressConflicts.CheckedChanged += new System.EventHandler(this.undressConflicts_CheckedChanged);
            // 
            // skillsTab
            // 
            this.skillsTab.Controls.Add(this.dispDelta);
            this.skillsTab.Controls.Add(this.skillCopyAll);
            this.skillsTab.Controls.Add(this.skillCopySel);
            this.skillsTab.Controls.Add(this.baseTotal);
            this.skillsTab.Controls.Add(this.label1);
            this.skillsTab.Controls.Add(this.locks);
            this.skillsTab.Controls.Add(this.setlocks);
            this.skillsTab.Controls.Add(this.resetDelta);
            this.skillsTab.Controls.Add(this.skillList);
            this.skillsTab.Location = new System.Drawing.Point(4, 46);
            this.skillsTab.Name = "skillsTab";
            this.skillsTab.Size = new System.Drawing.Size(640, 323);
            this.skillsTab.TabIndex = 2;
            this.skillsTab.Text = "Skills";
            // 
            // dispDelta
            // 
            this.dispDelta.Location = new System.Drawing.Point(483, 152);
            this.dispDelta.Name = "dispDelta";
            this.dispDelta.Size = new System.Drawing.Size(135, 23);
            this.dispDelta.TabIndex = 11;
            this.dispDelta.Text = "Display skill and stat changes";
            this.dispDelta.CheckedChanged += new System.EventHandler(this.dispDelta_CheckedChanged);
            // 
            // skillCopyAll
            // 
            this.skillCopyAll.ColorTable = office2010Blue1;
            this.skillCopyAll.Location = new System.Drawing.Point(483, 115);
            this.skillCopyAll.Name = "skillCopyAll";
            this.skillCopyAll.Size = new System.Drawing.Size(138, 23);
            this.skillCopyAll.TabIndex = 9;
            this.skillCopyAll.Text = "Copy All";
            this.skillCopyAll.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.skillCopyAll.Click += new System.EventHandler(this.skillCopyAll_Click);
            // 
            // skillCopySel
            // 
            this.skillCopySel.ColorTable = office2010Blue1;
            this.skillCopySel.Location = new System.Drawing.Point(483, 87);
            this.skillCopySel.Name = "skillCopySel";
            this.skillCopySel.Size = new System.Drawing.Size(138, 24);
            this.skillCopySel.TabIndex = 8;
            this.skillCopySel.Text = "Copy Selected";
            this.skillCopySel.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.skillCopySel.Click += new System.EventHandler(this.skillCopySel_Click);
            // 
            // baseTotal
            // 
            this.baseTotal.Location = new System.Drawing.Point(565, 186);
            this.baseTotal.Name = "baseTotal";
            this.baseTotal.ReadOnly = true;
            this.baseTotal.Size = new System.Drawing.Size(53, 22);
            this.baseTotal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(481, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base Total:";
            // 
            // locks
            // 
            this.locks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locks.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Locked"});
            this.locks.Location = new System.Drawing.Point(577, 46);
            this.locks.Name = "locks";
            this.locks.Size = new System.Drawing.Size(44, 28);
            this.locks.TabIndex = 5;
            // 
            // setlocks
            // 
            this.setlocks.ColorTable = office2010Blue1;
            this.setlocks.Location = new System.Drawing.Point(483, 48);
            this.setlocks.Name = "setlocks";
            this.setlocks.Size = new System.Drawing.Size(91, 24);
            this.setlocks.TabIndex = 4;
            this.setlocks.Text = "Set all locks:";
            this.setlocks.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setlocks.Click += new System.EventHandler(this.OnSetSkillLocks);
            // 
            // resetDelta
            // 
            this.resetDelta.ColorTable = office2010Blue1;
            this.resetDelta.Location = new System.Drawing.Point(483, 15);
            this.resetDelta.Name = "resetDelta";
            this.resetDelta.Size = new System.Drawing.Size(138, 23);
            this.resetDelta.TabIndex = 3;
            this.resetDelta.Text = "Reset  +/-";
            this.resetDelta.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.resetDelta.Click += new System.EventHandler(this.OnResetSkillDelta);
            // 
            // skillList
            // 
            this.skillList.AutoArrange = false;
            this.skillList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skillHDRName,
            this.skillHDRvalue,
            this.skillHDRbase,
            this.skillHDRdelta,
            this.skillHDRcap,
            this.skillHDRlock});
            this.skillList.FullRowSelect = true;
            this.skillList.Location = new System.Drawing.Point(8, 15);
            this.skillList.Name = "skillList";
            this.skillList.Size = new System.Drawing.Size(452, 300);
            this.skillList.TabIndex = 1;
            this.skillList.UseCompatibleStateImageBehavior = false;
            this.skillList.View = System.Windows.Forms.View.Details;
            this.skillList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnSkillColClick);
            this.skillList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skillList_MouseDown);
            // 
            // skillHDRName
            // 
            this.skillHDRName.Text = "Skill Name";
            this.skillHDRName.Width = 82;
            // 
            // skillHDRvalue
            // 
            this.skillHDRvalue.Text = "Value";
            this.skillHDRvalue.Width = 40;
            // 
            // skillHDRbase
            // 
            this.skillHDRbase.Text = "Base";
            this.skillHDRbase.Width = 40;
            // 
            // skillHDRdelta
            // 
            this.skillHDRdelta.Text = "+/-";
            this.skillHDRdelta.Width = 40;
            // 
            // skillHDRcap
            // 
            this.skillHDRcap.Text = "Cap";
            this.skillHDRcap.Width = 40;
            // 
            // skillHDRlock
            // 
            this.skillHDRlock.Text = "Lock";
            this.skillHDRlock.Width = 25;
            // 
            // agentsTab
            // 
            this.agentsTab.Controls.Add(this.agentB6);
            this.agentsTab.Controls.Add(this.agentB5);
            this.agentsTab.Controls.Add(this.agentList);
            this.agentsTab.Controls.Add(this.agentGroup);
            this.agentsTab.Controls.Add(this.agentB4);
            this.agentsTab.Controls.Add(this.agentB1);
            this.agentsTab.Controls.Add(this.agentB2);
            this.agentsTab.Controls.Add(this.agentB3);
            this.agentsTab.Location = new System.Drawing.Point(4, 46);
            this.agentsTab.Name = "agentsTab";
            this.agentsTab.Size = new System.Drawing.Size(640, 323);
            this.agentsTab.TabIndex = 6;
            this.agentsTab.Text = "Agents";
            // 
            // agentB6
            // 
            this.agentB6.ColorTable = office2010Blue1;
            this.agentB6.Location = new System.Drawing.Point(8, 202);
            this.agentB6.Name = "agentB6";
            this.agentB6.Size = new System.Drawing.Size(153, 23);
            this.agentB6.TabIndex = 6;
            this.agentB6.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB6.Click += new System.EventHandler(this.agentB6_Click);
            // 
            // agentB5
            // 
            this.agentB5.ColorTable = office2010Blue1;
            this.agentB5.Location = new System.Drawing.Point(8, 173);
            this.agentB5.Name = "agentB5";
            this.agentB5.Size = new System.Drawing.Size(153, 23);
            this.agentB5.TabIndex = 5;
            this.agentB5.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB5.Click += new System.EventHandler(this.agentB5_Click);
            // 
            // agentList
            // 
            this.agentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentList.Location = new System.Drawing.Point(8, 21);
            this.agentList.Name = "agentList";
            this.agentList.Size = new System.Drawing.Size(153, 28);
            this.agentList.TabIndex = 2;
            this.agentList.SelectedIndexChanged += new System.EventHandler(this.agentList_SelectedIndexChanged);
            // 
            // agentGroup
            // 
            this.agentGroup.Controls.Add(this.agentSubList);
            this.agentGroup.Location = new System.Drawing.Point(171, 9);
            this.agentGroup.Name = "agentGroup";
            this.agentGroup.Size = new System.Drawing.Size(460, 306);
            this.agentGroup.TabIndex = 1;
            this.agentGroup.TabStop = false;
            // 
            // agentSubList
            // 
            this.agentSubList.IntegralHeight = false;
            this.agentSubList.ItemHeight = 16;
            this.agentSubList.Location = new System.Drawing.Point(10, 18);
            this.agentSubList.Name = "agentSubList";
            this.agentSubList.Size = new System.Drawing.Size(444, 282);
            this.agentSubList.TabIndex = 0;
            // 
            // agentB4
            // 
            this.agentB4.ColorTable = office2010Blue1;
            this.agentB4.Location = new System.Drawing.Point(8, 144);
            this.agentB4.Name = "agentB4";
            this.agentB4.Size = new System.Drawing.Size(153, 23);
            this.agentB4.TabIndex = 4;
            this.agentB4.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB4.Click += new System.EventHandler(this.agentB4_Click);
            // 
            // agentB1
            // 
            this.agentB1.ColorTable = office2010Blue1;
            this.agentB1.Location = new System.Drawing.Point(8, 56);
            this.agentB1.Name = "agentB1";
            this.agentB1.Size = new System.Drawing.Size(153, 23);
            this.agentB1.TabIndex = 1;
            this.agentB1.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB1.Click += new System.EventHandler(this.agentB1_Click);
            // 
            // agentB2
            // 
            this.agentB2.ColorTable = office2010Blue1;
            this.agentB2.Location = new System.Drawing.Point(8, 85);
            this.agentB2.Name = "agentB2";
            this.agentB2.Size = new System.Drawing.Size(153, 23);
            this.agentB2.TabIndex = 2;
            this.agentB2.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB2.Click += new System.EventHandler(this.agentB2_Click);
            // 
            // agentB3
            // 
            this.agentB3.ColorTable = office2010Blue1;
            this.agentB3.Location = new System.Drawing.Point(8, 115);
            this.agentB3.Name = "agentB3";
            this.agentB3.Size = new System.Drawing.Size(153, 23);
            this.agentB3.TabIndex = 3;
            this.agentB3.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.agentB3.Click += new System.EventHandler(this.agentB3_Click);
            // 
            // hotkeysTab
            // 
            this.hotkeysTab.Controls.Add(this.hkStatus);
            this.hotkeysTab.Controls.Add(this.hotkeyTree);
            this.hotkeysTab.Controls.Add(this.groupBox8);
            this.hotkeysTab.Controls.Add(this.dohotkey);
            this.hotkeysTab.Location = new System.Drawing.Point(4, 46);
            this.hotkeysTab.Name = "hotkeysTab";
            this.hotkeysTab.Size = new System.Drawing.Size(640, 323);
            this.hotkeysTab.TabIndex = 4;
            this.hotkeysTab.Text = "Hot Keys";
            // 
            // hkStatus
            // 
            this.hkStatus.Location = new System.Drawing.Point(439, 204);
            this.hkStatus.Name = "hkStatus";
            this.hkStatus.Size = new System.Drawing.Size(192, 18);
            this.hkStatus.TabIndex = 7;
            // 
            // hotkeyTree
            // 
            this.hotkeyTree.HideSelection = false;
            this.hotkeyTree.Location = new System.Drawing.Point(8, 15);
            this.hotkeyTree.Name = "hotkeyTree";
            this.hotkeyTree.Size = new System.Drawing.Size(415, 300);
            this.hotkeyTree.Sorted = true;
            this.hotkeyTree.TabIndex = 6;
            this.hotkeyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.hotkeyTree_AfterSelect);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkPass);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.unsetHK);
            this.groupBox8.Controls.Add(this.setHK);
            this.groupBox8.Controls.Add(this.key);
            this.groupBox8.Controls.Add(this.chkCtrl);
            this.groupBox8.Controls.Add(this.chkAlt);
            this.groupBox8.Controls.Add(this.chkShift);
            this.groupBox8.Location = new System.Drawing.Point(439, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(192, 143);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Hot Key";
            // 
            // chkPass
            // 
            this.chkPass.Location = new System.Drawing.Point(10, 78);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(172, 23);
            this.chkPass.TabIndex = 9;
            this.chkPass.Text = "Pass to UO";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key:";
            // 
            // unsetHK
            // 
            this.unsetHK.ColorTable = office2010Blue1;
            this.unsetHK.Location = new System.Drawing.Point(10, 111);
            this.unsetHK.Name = "unsetHK";
            this.unsetHK.Size = new System.Drawing.Size(62, 23);
            this.unsetHK.TabIndex = 6;
            this.unsetHK.Text = "Unset";
            this.unsetHK.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.unsetHK.Click += new System.EventHandler(this.unsetHK_Click);
            // 
            // setHK
            // 
            this.setHK.ColorTable = office2010Blue1;
            this.setHK.Location = new System.Drawing.Point(125, 111);
            this.setHK.Name = "setHK";
            this.setHK.Size = new System.Drawing.Size(57, 23);
            this.setHK.TabIndex = 5;
            this.setHK.Text = "Set";
            this.setHK.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setHK.Click += new System.EventHandler(this.setHK_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(43, 50);
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Size = new System.Drawing.Size(139, 22);
            this.key.TabIndex = 4;
            this.key.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_KeyUp);
            this.key.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_MouseDown);
            this.key.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.key_MouseWheel);
            // 
            // chkCtrl
            // 
            this.chkCtrl.Location = new System.Drawing.Point(10, 23);
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.Size = new System.Drawing.Size(52, 23);
            this.chkCtrl.TabIndex = 1;
            this.chkCtrl.Text = "Ctrl";
            // 
            // chkAlt
            // 
            this.chkAlt.Location = new System.Drawing.Point(72, 23);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(43, 23);
            this.chkAlt.TabIndex = 2;
            this.chkAlt.Text = "Alt";
            // 
            // chkShift
            // 
            this.chkShift.Location = new System.Drawing.Point(125, 23);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(57, 23);
            this.chkShift.TabIndex = 3;
            this.chkShift.Text = "Shift";
            // 
            // dohotkey
            // 
            this.dohotkey.ColorTable = office2010Blue1;
            this.dohotkey.Location = new System.Drawing.Point(439, 167);
            this.dohotkey.Name = "dohotkey";
            this.dohotkey.Size = new System.Drawing.Size(192, 23);
            this.dohotkey.TabIndex = 5;
            this.dohotkey.Text = "Execute Selected";
            this.dohotkey.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.dohotkey.Click += new System.EventHandler(this.dohotkey_Click);
            // 
            // macrosTab
            // 
            this.macrosTab.Controls.Add(this.macroTree);
            this.macrosTab.Controls.Add(this.macroActGroup);
            this.macrosTab.Controls.Add(this.delMacro);
            this.macrosTab.Controls.Add(this.newMacro);
            this.macrosTab.Location = new System.Drawing.Point(4, 46);
            this.macrosTab.Name = "macrosTab";
            this.macrosTab.Size = new System.Drawing.Size(640, 323);
            this.macrosTab.TabIndex = 7;
            this.macrosTab.Text = "Macros";
            // 
            // macroTree
            // 
            this.macroTree.FullRowSelect = true;
            this.macroTree.HideSelection = false;
            this.macroTree.Location = new System.Drawing.Point(8, 14);
            this.macroTree.Name = "macroTree";
            this.macroTree.Size = new System.Drawing.Size(163, 266);
            this.macroTree.Sorted = true;
            this.macroTree.TabIndex = 4;
            this.macroTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.macroTree_AfterSelect);
            this.macroTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.macroTree_MouseDown);
            // 
            // macroActGroup
            // 
            this.macroActGroup.Controls.Add(this.adveditorMacro);
            this.macroActGroup.Controls.Add(this.macroImport);
            this.macroActGroup.Controls.Add(this.exportMacro);
            this.macroActGroup.Controls.Add(this.waitDisp);
            this.macroActGroup.Controls.Add(this.loopMacro);
            this.macroActGroup.Controls.Add(this.recMacro);
            this.macroActGroup.Controls.Add(this.playMacro);
            this.macroActGroup.Controls.Add(this.actionList);
            this.macroActGroup.Location = new System.Drawing.Point(180, 10);
            this.macroActGroup.Name = "macroActGroup";
            this.macroActGroup.Size = new System.Drawing.Size(451, 305);
            this.macroActGroup.TabIndex = 3;
            this.macroActGroup.TabStop = false;
            this.macroActGroup.Text = "Actions";
            this.macroActGroup.Visible = false;
            // 
            // adveditorMacro
            // 
            this.adveditorMacro.ColorTable = office2010Blue1;
            this.adveditorMacro.Location = new System.Drawing.Point(373, 151);
            this.adveditorMacro.Name = "adveditorMacro";
            this.adveditorMacro.Size = new System.Drawing.Size(72, 23);
            this.adveditorMacro.TabIndex = 8;
            this.adveditorMacro.Text = "Adv. Editor";
            this.adveditorMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.adveditorMacro.Click += new System.EventHandler(this.adveditorMacro_Click);
            // 
            // macroImport
            // 
            this.macroImport.ColorTable = office2010Blue1;
            this.macroImport.Location = new System.Drawing.Point(373, 122);
            this.macroImport.Name = "macroImport";
            this.macroImport.Size = new System.Drawing.Size(72, 23);
            this.macroImport.TabIndex = 7;
            this.macroImport.Text = "Import";
            this.macroImport.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.macroImport.Click += new System.EventHandler(this.macroImport_Click);
            // 
            // exportMacro
            // 
            this.exportMacro.ColorTable = office2010Blue1;
            this.exportMacro.Location = new System.Drawing.Point(373, 93);
            this.exportMacro.Name = "exportMacro";
            this.exportMacro.Size = new System.Drawing.Size(72, 23);
            this.exportMacro.TabIndex = 6;
            this.exportMacro.Text = "Export";
            this.exportMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.exportMacro.Click += new System.EventHandler(this.exportMacro_Click);
            // 
            // waitDisp
            // 
            this.waitDisp.Location = new System.Drawing.Point(370, 203);
            this.waitDisp.Name = "waitDisp";
            this.waitDisp.Size = new System.Drawing.Size(72, 50);
            this.waitDisp.TabIndex = 5;
            this.waitDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loopMacro
            // 
            this.loopMacro.Location = new System.Drawing.Point(373, 268);
            this.loopMacro.Name = "loopMacro";
            this.loopMacro.Size = new System.Drawing.Size(72, 23);
            this.loopMacro.TabIndex = 4;
            this.loopMacro.Text = "Loop";
            this.loopMacro.CheckedChanged += new System.EventHandler(this.loopMacro_CheckedChanged);
            // 
            // recMacro
            // 
            this.recMacro.ColorTable = office2010Blue1;
            this.recMacro.Location = new System.Drawing.Point(373, 64);
            this.recMacro.Name = "recMacro";
            this.recMacro.Size = new System.Drawing.Size(72, 23);
            this.recMacro.TabIndex = 3;
            this.recMacro.Text = "Record";
            this.recMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.recMacro.Click += new System.EventHandler(this.recMacro_Click);
            // 
            // actionList
            // 
            this.actionList.BackColor = System.Drawing.SystemColors.Window;
            this.actionList.HorizontalScrollbar = true;
            this.actionList.IntegralHeight = false;
            this.actionList.ItemHeight = 16;
            this.actionList.Location = new System.Drawing.Point(10, 18);
            this.actionList.Name = "actionList";
            this.actionList.Size = new System.Drawing.Size(345, 281);
            this.actionList.TabIndex = 0;
            this.actionList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.actionList_KeyDown);
            this.actionList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.actionList_MouseDown);
            // 
            // delMacro
            // 
            this.delMacro.ColorTable = office2010Blue1;
            this.delMacro.Location = new System.Drawing.Point(99, 286);
            this.delMacro.Name = "delMacro";
            this.delMacro.Size = new System.Drawing.Size(72, 23);
            this.delMacro.TabIndex = 2;
            this.delMacro.Text = "Remove";
            this.delMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.delMacro.Click += new System.EventHandler(this.delMacro_Click);
            // 
            // newMacro
            // 
            this.newMacro.ColorTable = office2010Blue1;
            this.newMacro.Location = new System.Drawing.Point(8, 286);
            this.newMacro.Name = "newMacro";
            this.newMacro.Size = new System.Drawing.Size(72, 23);
            this.newMacro.TabIndex = 1;
            this.newMacro.Text = "New...";
            this.newMacro.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.newMacro.Click += new System.EventHandler(this.newMacro_Click);
            // 
            // videoTab
            // 
            this.videoTab.Controls.Add(this.txtRecFolder);
            this.videoTab.Controls.Add(this.recFolder);
            this.videoTab.Controls.Add(this.label13);
            this.videoTab.Controls.Add(this.groupBox7);
            this.videoTab.Controls.Add(this.groupBox10);
            this.videoTab.Controls.Add(this.groupBox9);
            this.videoTab.Location = new System.Drawing.Point(4, 46);
            this.videoTab.Name = "videoTab";
            this.videoTab.Size = new System.Drawing.Size(640, 323);
            this.videoTab.TabIndex = 11;
            this.videoTab.Text = "Video Capture";
            // 
            // txtRecFolder
            // 
            this.txtRecFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtRecFolder.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.txtRecFolder.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.txtRecFolder.Location = new System.Drawing.Point(8, 34);
            this.txtRecFolder.Name = "txtRecFolder";
            this.txtRecFolder.Padding = new System.Windows.Forms.Padding(1);
            this.txtRecFolder.Size = new System.Drawing.Size(271, 22);
            this.txtRecFolder.TabIndex = 16;
            this.txtRecFolder.TextChanged += new System.EventHandler(this.txtRecFolder_TextChanged);
            // 
            // recFolder
            // 
            this.recFolder.ColorTable = office2010Blue1;
            this.recFolder.Location = new System.Drawing.Point(285, 34);
            this.recFolder.Name = "recFolder";
            this.recFolder.Size = new System.Drawing.Size(27, 21);
            this.recFolder.TabIndex = 15;
            this.recFolder.Text = "...";
            this.recFolder.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.recFolder.Click += new System.EventHandler(this.recFolder_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Recordings Folder:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.vidRec);
            this.groupBox7.Location = new System.Drawing.Point(11, 79);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 55);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PacketVideo Recording";
            // 
            // vidRec
            // 
            this.vidRec.ColorTable = office2010Blue1;
            this.vidRec.Location = new System.Drawing.Point(43, 21);
            this.vidRec.Name = "vidRec";
            this.vidRec.Size = new System.Drawing.Size(218, 23);
            this.vidRec.TabIndex = 1;
            this.vidRec.Text = "Record PacketVideo";
            this.vidRec.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.vidRec.Click += new System.EventHandler(this.vidRec_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.flipVidVert);
            this.groupBox10.Controls.Add(this.flipVidHoriz);
            this.groupBox10.Controls.Add(this.recAVI);
            this.groupBox10.Controls.Add(this.aviRes);
            this.groupBox10.Controls.Add(this.aviFPS);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Location = new System.Drawing.Point(11, 159);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(301, 128);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "AVI Video Recording";
            // 
            // flipVidVert
            // 
            this.flipVidVert.Location = new System.Drawing.Point(154, 53);
            this.flipVidVert.Name = "flipVidVert";
            this.flipVidVert.Size = new System.Drawing.Size(74, 23);
            this.flipVidVert.TabIndex = 6;
            this.flipVidVert.Text = "Verticle";
            this.flipVidVert.CheckedChanged += new System.EventHandler(this.flipVidVert_CheckedChanged);
            // 
            // flipVidHoriz
            // 
            this.flipVidHoriz.Location = new System.Drawing.Point(60, 53);
            this.flipVidHoriz.Name = "flipVidHoriz";
            this.flipVidHoriz.Size = new System.Drawing.Size(89, 23);
            this.flipVidHoriz.TabIndex = 5;
            this.flipVidHoriz.Text = "Horizontal";
            this.flipVidHoriz.CheckedChanged += new System.EventHandler(this.flipVidHoriz_CheckedChanged);
            // 
            // recAVI
            // 
            this.recAVI.ColorTable = office2010Blue1;
            this.recAVI.Location = new System.Drawing.Point(12, 79);
            this.recAVI.Name = "recAVI";
            this.recAVI.Size = new System.Drawing.Size(218, 23);
            this.recAVI.TabIndex = 4;
            this.recAVI.Text = "Record AVI Video...";
            this.recAVI.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.recAVI.Click += new System.EventHandler(this.recAVI_Click);
            // 
            // aviRes
            // 
            this.aviRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aviRes.Items.AddRange(new object[] {
            "Full Size",
            "3/4",
            "1/2",
            "1/4"});
            this.aviRes.Location = new System.Drawing.Point(151, 18);
            this.aviRes.Name = "aviRes";
            this.aviRes.Size = new System.Drawing.Size(79, 28);
            this.aviRes.TabIndex = 3;
            this.aviRes.SelectedIndexChanged += new System.EventHandler(this.aviRes_SelectedIndexChanged);
            // 
            // aviFPS
            // 
            this.aviFPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.aviFPS.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.aviFPS.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.aviFPS.Location = new System.Drawing.Point(43, 20);
            this.aviFPS.Name = "aviFPS";
            this.aviFPS.Padding = new System.Windows.Forms.Padding(1);
            this.aviFPS.Size = new System.Drawing.Size(31, 22);
            this.aviFPS.TabIndex = 1;
            this.aviFPS.TextChanged += new System.EventHandler(this.aviFPS_TextChanged);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(84, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Resolution:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "FPS:";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(12, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 7;
            this.label19.Text = "Flip:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rpvTime);
            this.groupBox9.Controls.Add(this.playSpeed);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.vidClose);
            this.groupBox9.Controls.Add(this.playPos);
            this.groupBox9.Controls.Add(this.vidPlayStop);
            this.groupBox9.Controls.Add(this.vidPlay);
            this.groupBox9.Controls.Add(this.vidPlayInfo);
            this.groupBox9.Controls.Add(this.vidOpen);
            this.groupBox9.Location = new System.Drawing.Point(337, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(294, 304);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PacketVideo Playback";
            // 
            // rpvTime
            // 
            this.rpvTime.Location = new System.Drawing.Point(158, 78);
            this.rpvTime.Name = "rpvTime";
            this.rpvTime.Size = new System.Drawing.Size(130, 23);
            this.rpvTime.TabIndex = 8;
            this.rpvTime.Text = "00:00/00:00";
            // 
            // playSpeed
            // 
            this.playSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playSpeed.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "Reg",
            "2x",
            "4x"});
            this.playSpeed.Location = new System.Drawing.Point(233, 47);
            this.playSpeed.Name = "playSpeed";
            this.playSpeed.Size = new System.Drawing.Size(53, 28);
            this.playSpeed.TabIndex = 7;
            this.playSpeed.SelectedIndexChanged += new System.EventHandler(this.playSpeed_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(175, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Speed:";
            // 
            // vidClose
            // 
            this.vidClose.ColorTable = office2010Blue1;
            this.vidClose.Enabled = false;
            this.vidClose.Location = new System.Drawing.Point(161, 21);
            this.vidClose.Name = "vidClose";
            this.vidClose.Size = new System.Drawing.Size(125, 23);
            this.vidClose.TabIndex = 5;
            this.vidClose.Text = "Close";
            this.vidClose.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.vidClose.Click += new System.EventHandler(this.vidClose_Click);
            // 
            // playPos
            // 
            this.playPos.AutoSize = false;
            this.playPos.Location = new System.Drawing.Point(5, 78);
            this.playPos.Maximum = 1;
            this.playPos.Name = "playPos";
            this.playPos.Size = new System.Drawing.Size(158, 23);
            this.playPos.TabIndex = 4;
            this.playPos.TickFrequency = 5;
            this.playPos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.playPos.Scroll += new System.EventHandler(this.playPos_Scroll);
            // 
            // vidPlayStop
            // 
            this.vidPlayStop.ColorTable = office2010Blue1;
            this.vidPlayStop.Enabled = false;
            this.vidPlayStop.Location = new System.Drawing.Point(82, 49);
            this.vidPlayStop.Name = "vidPlayStop";
            this.vidPlayStop.Size = new System.Drawing.Size(55, 23);
            this.vidPlayStop.TabIndex = 3;
            this.vidPlayStop.Text = "Stop";
            this.vidPlayStop.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.vidPlayStop.Click += new System.EventHandler(this.vidPlayStop_Click);
            // 
            // vidPlay
            // 
            this.vidPlay.ColorTable = office2010Blue1;
            this.vidPlay.Enabled = false;
            this.vidPlay.Location = new System.Drawing.Point(12, 49);
            this.vidPlay.Name = "vidPlay";
            this.vidPlay.Size = new System.Drawing.Size(55, 23);
            this.vidPlay.TabIndex = 2;
            this.vidPlay.Text = "Play";
            this.vidPlay.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.vidPlay.Click += new System.EventHandler(this.vidPlay_Click);
            // 
            // vidPlayInfo
            // 
            this.vidPlayInfo.Location = new System.Drawing.Point(9, 107);
            this.vidPlayInfo.Name = "vidPlayInfo";
            this.vidPlayInfo.Size = new System.Drawing.Size(279, 194);
            this.vidPlayInfo.TabIndex = 1;
            // 
            // vidOpen
            // 
            this.vidOpen.ColorTable = office2010Blue1;
            this.vidOpen.Location = new System.Drawing.Point(12, 21);
            this.vidOpen.Name = "vidOpen";
            this.vidOpen.Size = new System.Drawing.Size(125, 23);
            this.vidOpen.TabIndex = 0;
            this.vidOpen.Text = "Open...";
            this.vidOpen.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.vidOpen.Click += new System.EventHandler(this.vidOpen_Click);
            // 
            // screenshotTab
            // 
            this.screenshotTab.Controls.Add(this.imgFmt);
            this.screenshotTab.Controls.Add(this.label12);
            this.screenshotTab.Controls.Add(this.capNow);
            this.screenshotTab.Controls.Add(this.screenPath);
            this.screenshotTab.Controls.Add(this.radioUO);
            this.screenshotTab.Controls.Add(this.radioFull);
            this.screenshotTab.Controls.Add(this.screenAutoCap);
            this.screenshotTab.Controls.Add(this.setScnPath);
            this.screenshotTab.Controls.Add(this.screensList);
            this.screenshotTab.Controls.Add(this.screenPrev);
            this.screenshotTab.Controls.Add(this.dispTime);
            this.screenshotTab.Location = new System.Drawing.Point(4, 46);
            this.screenshotTab.Name = "screenshotTab";
            this.screenshotTab.Size = new System.Drawing.Size(640, 323);
            this.screenshotTab.TabIndex = 8;
            this.screenshotTab.Text = "Screen Shots";
            // 
            // imgFmt
            // 
            this.imgFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgFmt.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp",
            "gif",
            "tif",
            "wmf",
            "exif",
            "emf"});
            this.imgFmt.Location = new System.Drawing.Point(104, 218);
            this.imgFmt.Name = "imgFmt";
            this.imgFmt.Size = new System.Drawing.Size(86, 28);
            this.imgFmt.TabIndex = 11;
            this.imgFmt.SelectedIndexChanged += new System.EventHandler(this.imgFmt_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Image Format:";
            // 
            // capNow
            // 
            this.capNow.ColorTable = office2010Blue1;
            this.capNow.Location = new System.Drawing.Point(295, 15);
            this.capNow.Name = "capNow";
            this.capNow.Size = new System.Drawing.Size(342, 23);
            this.capNow.TabIndex = 8;
            this.capNow.Text = "Take Screen Shot Now";
            this.capNow.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.capNow.Click += new System.EventHandler(this.capNow_Click);
            // 
            // screenPath
            // 
            this.screenPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.screenPath.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            this.screenPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.screenPath.Location = new System.Drawing.Point(8, 16);
            this.screenPath.Name = "screenPath";
            this.screenPath.Padding = new System.Windows.Forms.Padding(1);
            this.screenPath.Size = new System.Drawing.Size(236, 22);
            this.screenPath.TabIndex = 7;
            this.screenPath.TextChanged += new System.EventHandler(this.screenPath_TextChanged);
            // 
            // radioUO
            // 
            this.radioUO.Location = new System.Drawing.Point(8, 250);
            this.radioUO.Name = "radioUO";
            this.radioUO.Size = new System.Drawing.Size(105, 23);
            this.radioUO.TabIndex = 6;
            this.radioUO.Text = "UO Only";
            this.radioUO.CheckedChanged += new System.EventHandler(this.radioUO_CheckedChanged);
            // 
            // radioFull
            // 
            this.radioFull.Location = new System.Drawing.Point(118, 250);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(106, 23);
            this.radioFull.TabIndex = 5;
            this.radioFull.Text = "Full Screen";
            this.radioFull.CheckedChanged += new System.EventHandler(this.radioFull_CheckedChanged);
            // 
            // screenAutoCap
            // 
            this.screenAutoCap.Location = new System.Drawing.Point(8, 292);
            this.screenAutoCap.Name = "screenAutoCap";
            this.screenAutoCap.Size = new System.Drawing.Size(216, 23);
            this.screenAutoCap.TabIndex = 4;
            this.screenAutoCap.Text = "Auto Death Screen Capture";
            this.screenAutoCap.CheckedChanged += new System.EventHandler(this.screenAutoCap_CheckedChanged);
            // 
            // setScnPath
            // 
            this.setScnPath.ColorTable = office2010Blue1;
            this.setScnPath.Location = new System.Drawing.Point(250, 19);
            this.setScnPath.Name = "setScnPath";
            this.setScnPath.Size = new System.Drawing.Size(26, 19);
            this.setScnPath.TabIndex = 3;
            this.setScnPath.Text = "...";
            this.setScnPath.Theme = RazorUIMod.Theme.MSOffice2010_BLUE;
            this.setScnPath.Click += new System.EventHandler(this.setScnPath_Click);
            // 
            // screensList
            // 
            this.screensList.IntegralHeight = false;
            this.screensList.ItemHeight = 16;
            this.screensList.Location = new System.Drawing.Point(8, 43);
            this.screensList.Name = "screensList";
            this.screensList.Size = new System.Drawing.Size(268, 169);
            this.screensList.Sorted = true;
            this.screensList.TabIndex = 1;
            this.screensList.SelectedIndexChanged += new System.EventHandler(this.screensList_SelectedIndexChanged);
            this.screensList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screensList_MouseDown);
            // 
            // screenPrev
            // 
            this.screenPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenPrev.Location = new System.Drawing.Point(295, 42);
            this.screenPrev.Name = "screenPrev";
            this.screenPrev.Size = new System.Drawing.Size(342, 278);
            this.screenPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenPrev.TabIndex = 0;
            this.screenPrev.TabStop = false;
            this.screenPrev.Click += new System.EventHandler(this.screenPrev_Click);
            // 
            // dispTime
            // 
            this.dispTime.Location = new System.Drawing.Point(8, 273);
            this.dispTime.Name = "dispTime";
            this.dispTime.Size = new System.Drawing.Size(216, 23);
            this.dispTime.TabIndex = 9;
            this.dispTime.Text = "Include Timestamp on images";
            this.dispTime.CheckedChanged += new System.EventHandler(this.dispTime_CheckedChanged);
            // 
            // statusTab
            // 
            this.statusTab.Controls.Add(this.statusBox);
            this.statusTab.Controls.Add(this.textBox1);
            this.statusTab.Controls.Add(this.btcLabel);
            this.statusTab.Controls.Add(this.features);
            this.statusTab.Controls.Add(this.issuesLink);
            this.statusTab.Controls.Add(this.homeLink);
            this.statusTab.Controls.Add(this.wikiLink);
            this.statusTab.Location = new System.Drawing.Point(4, 46);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(640, 323);
            this.statusTab.TabIndex = 9;
            this.statusTab.Text = "Help && Status";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.HideSelection = false;
            this.statusBox.Location = new System.Drawing.Point(5, 9);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(222, 206);
            this.statusBox.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1GdrG1uXDTjXgZe7seMic5FgFDKLLJVEuj";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btcLabel
            // 
            this.btcLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcLabel.Location = new System.Drawing.Point(269, 9);
            this.btcLabel.Name = "btcLabel";
            this.btcLabel.Size = new System.Drawing.Size(197, 18);
            this.btcLabel.TabIndex = 10;
            this.btcLabel.Text = "Donate BTC to Razor";
            this.btcLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btcLabel.Click += new System.EventHandler(this.btcLabel_Click);
            // 
            // features
            // 
            this.features.Cursor = System.Windows.Forms.Cursors.No;
            this.features.Location = new System.Drawing.Point(234, 120);
            this.features.Multiline = true;
            this.features.Name = "features";
            this.features.ReadOnly = true;
            this.features.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.features.Size = new System.Drawing.Size(260, 95);
            this.features.TabIndex = 9;
            this.features.Visible = false;
            // 
            // issuesLink
            // 
            this.issuesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.issuesLink.Location = new System.Drawing.Point(269, 93);
            this.issuesLink.Name = "issuesLink";
            this.issuesLink.Size = new System.Drawing.Size(197, 19);
            this.issuesLink.TabIndex = 8;
            this.issuesLink.TabStop = true;
            this.issuesLink.Text = "Issue Tracker";
            this.issuesLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.issuesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
            // 
            // homeLink
            // 
            this.homeLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.homeLink.Location = new System.Drawing.Point(269, 57);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(197, 18);
            this.homeLink.TabIndex = 7;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "Razor Homepage";
            this.homeLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLink_LinkClicked);
            // 
            // wikiLink
            // 
            this.wikiLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.wikiLink.Location = new System.Drawing.Point(269, 75);
            this.wikiLink.Name = "wikiLink";
            this.wikiLink.Size = new System.Drawing.Size(197, 18);
            this.wikiLink.TabIndex = 6;
            this.wikiLink.TabStop = true;
            this.wikiLink.Text = "Razor Wiki";
            this.wikiLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wikiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wikiLink_LinkClicked);
            // 
            // timerTimer
            // 
            this.timerTimer.Enabled = true;
            this.timerTimer.Interval = 5;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(647, 373);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Razor v{0}";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabs.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.moreOptTab.ResumeLayout(false);
            this.moreMoreOptTab.ResumeLayout(false);
            this.displayTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.dressTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.skillsTab.ResumeLayout(false);
            this.skillsTab.PerformLayout();
            this.agentsTab.ResumeLayout(false);
            this.agentGroup.ResumeLayout(false);
            this.hotkeysTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.macrosTab.ResumeLayout(false);
            this.macroActGroup.ResumeLayout(false);
            this.videoTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playPos)).EndInit();
            this.screenshotTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenPrev)).EndInit();
            this.statusTab.ResumeLayout(false);
            this.statusTab.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		protected override void WndProc( ref Message msg )
		{
			if ( msg.Msg == ClientCommunication.WM_UONETEVENT )
				msg.Result = (IntPtr)( ClientCommunication.OnMessage( this, (uint)msg.WParam.ToInt32(), msg.LParam.ToInt32() ) ? 1 : 0 );
			else if ( msg.Msg >= (int)ClientCommunication.UOAMessage.First && msg.Msg <= (int)ClientCommunication.UOAMessage.Last )
				msg.Result = (IntPtr)ClientCommunication.OnUOAMessage(this, msg.Msg, msg.WParam.ToInt32(), msg.LParam.ToInt32());
			else 
				base.WndProc( ref msg );
		}

		private void DisableCloseButton()
		{
			IntPtr menu = GetSystemMenu( this.Handle, false );
			EnableMenuItem( menu, 0xF060, 0x00000002 ); //menu, SC_CLOSE, MF_BYCOMMAND|MF_GRAYED
			m_CanClose = false;
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			//ClientCommunication.SetCustomNotoHue( 0x2 );

			Timer.Control = timerTimer;

			new StatsTimer( this ).Start();

			this.Hide();
			Language.LoadControlNames( this );

			bool st = Config.GetBool( "Systray" );
			taskbar.Checked = this.ShowInTaskbar = !st;
			systray.Checked = m_NotifyIcon.Visible = st;

			//this.Text = String.Format( this.Text, Engine.Version );
			UpdateTitle();

			if ( !ClientCommunication.InstallHooks( this.Handle ) ) // WaitForInputIdle done here
			{
				m_CanClose = true;
				SplashScreen.End();
				this.Close();
				System.Diagnostics.Process.GetCurrentProcess().Kill();
				return;
			}

			SplashScreen.Message = LocString.Welcome;
            InitConfig();

			this.Show();
			this.BringToFront();

			Engine.ActiveWindow = this;

			DisableCloseButton();
			
			tabs_IndexChanged(this,null); // load first tab

			m_ProfileConfirmLoad = false;
			Config.SetupProfilesList( profiles, Config.CurrentProfile.Name );
			m_ProfileConfirmLoad = true;

			showWelcome.Checked = Utility.ToInt32( Config.GetRegString( Microsoft.Win32.Registry.CurrentUser, "ShowWelcome" ), 1 ) == 1;
				
			m_Tip.Active = true;
            m_Tip.SetToolTip(titleStr, Language.GetString(LocString.TitleBarTip));

            SplashScreen.End();
		}
		
		private bool m_Initializing = false;
		public void InitConfig()
		{
			m_Initializing = true;
			
			this.opacity.AutoSize = false;
			//this.opacity.Size = new System.Drawing.Size(156, 16);

			opacity.Value = Config.GetInt( "Opacity" );
			this.Opacity = ((float)opacity.Value) / 100.0;
			opacityLabel.Text = Language.Format( LocString.OpacityA1, opacity.Value );

			this.TopMost = alwaysTop.Checked = Config.GetBool( "AlwaysOnTop" );
			this.Location = new System.Drawing.Point( Config.GetInt( "WindowX" ), Config.GetInt( "WindowY" ) );
			this.TopLevel = true;

			bool onScreen = false;
			foreach ( Screen s in Screen.AllScreens )
			{
				if ( s.Bounds.Contains( this.Location.X + this.Width, this.Location.Y+this.Height ) ||
					s.Bounds.Contains( this.Location.X-this.Width, this.Location.Y-this.Height ) )
				{
					onScreen = true;
					break;
				}
			}

			if ( !onScreen )
				this.Location = Point.Empty;

			spellUnequip.Checked = Config.GetBool( "SpellUnequip" );
			ltRange.Enabled = rangeCheckLT.Checked = Config.GetBool( "RangeCheckLT" );
			ltRange.Text = Config.GetInt( "LTRange" ).ToString();

			counters.BeginUpdate();
			if ( Config.GetBool( "SortCounters" ) )
			{
				counters.Sorting = SortOrder.None;
				counters.ListViewItemSorter = CounterLVIComparer.Instance;
				counters.Sort();
			}
			else
			{
				counters.ListViewItemSorter = null;
				counters.Sorting = SortOrder.Ascending;
			}
			counters.EndUpdate();
			counters.Refresh();

			incomingMob.Checked = Config.GetBool( "ShowMobNames" );
			incomingCorpse.Checked = Config.GetBool( "ShowCorpseNames" );
			checkNewConts.Checked = Config.GetBool( "AutoSearch" );
			excludePouches.Checked = Config.GetBool( "NoSearchPouches" );
			excludePouches.Enabled = checkNewConts.Checked;
			warnNum.Enabled = warnCount.Checked = Config.GetBool( "CounterWarn" );
			warnNum.Text = Config.GetInt( "CounterWarnAmount" ).ToString();
			QueueActions.Checked = Config.GetBool( "QueueActions" );
			queueTargets.Checked = Config.GetBool( "QueueTargets" );
			chkForceSpeechHue.Checked = setSpeechHue.Enabled = Config.GetBool( "ForceSpeechHue" );
			chkForceSpellHue.Checked = setBeneHue.Enabled = setNeuHue.Enabled = setHarmHue.Enabled = Config.GetBool( "ForceSpellHue" );
			if ( Config.GetInt( "LTHilight" ) != 0 )
			{
				InitPreviewHue( lthilight, "LTHilight" );
				//ClientCommunication.SetCustomNotoHue( Config.GetInt( "LTHilight" ) );
				lthilight.Checked = setLTHilight.Enabled = true;
			} 
			else
			{
				//ClientCommunication.SetCustomNotoHue( 0 );
				lthilight.Checked = setLTHilight.Enabled = false;
			}
			
			txtSpellFormat.Text = Config.GetString( "SpellFormat" );
			txtObjDelay.Text = Config.GetInt( "ObjectDelay" ).ToString();
			chkStealth.Checked = Config.GetBool( "CountStealthSteps" );

			spamFilter.Checked = Config.GetBool( "FilterSpam" );
			screenAutoCap.Checked = Config.GetBool( "AutoCap" );
			radioUO.Checked = !(radioFull.Checked = Config.GetBool( "CapFullScreen" ));
			screenPath.Text = Config.GetString( "CapPath" );
			dispTime.Checked = Config.GetBool( "CapTimeStamp" );
			blockDis.Checked = Config.GetBool( "BlockDismount" );
			alwaysStealth.Checked = Config.GetBool( "AlwaysStealth" );
			autoOpenDoors.Checked = Config.GetBool( "AutoOpenDoors" );

			msglvl.SelectedIndex = Config.GetInt( "MessageLevel" );

			try
			{
				imgFmt.SelectedItem = Config.GetString( "ImageFormat" );
			}
			catch
			{
				imgFmt.SelectedIndex = 0;
				Config.SetProperty( "ImageFormat", "jpg" );
			}

			PacketPlayer.SetControls( vidPlayInfo, vidRec, vidPlay, vidPlayStop, vidClose, playPos, rpvTime );
			txtRecFolder.Text = Config.GetString( "RecFolder" );
			aviFPS.Text = Config.GetInt( "AviFPS" ).ToString();
			aviRes.SelectedIndex = Config.GetInt( "AviRes" );
			playSpeed.SelectedIndex = 2;

			InitPreviewHue( lblExHue, "ExemptColor" );
			InitPreviewHue( lblMsgHue, "SysColor" );
			InitPreviewHue( lblWarnHue, "WarningColor" );
			InitPreviewHue( chkForceSpeechHue, "SpeechHue" );
			InitPreviewHue( lblBeneHue, "BeneficialSpellHue" );
			InitPreviewHue( lblHarmHue, "HarmfulSpellHue" );
			InitPreviewHue( lblNeuHue, "NeutralSpellHue" );

			undressConflicts.Checked = Config.GetBool( "UndressConflicts" );
			taskbar.Checked = !(systray.Checked = Config.GetBool( "Systray" ));
			titlebarImages.Checked = Config.GetBool( "TitlebarImages" );
			highlightSpellReags.Checked = Config.GetBool( "HighlightReagents" );

			dispDelta.Checked = Config.GetBool( "DisplaySkillChanges" );
			titleStr.Enabled = showInBar.Checked = Config.GetBool( "TitleBarDisplay" );
			titleStr.Text = Config.GetString( "TitleBarText" );

			showNotoHue.Checked = Config.GetBool( "ShowNotoHue" );

			corpseRange.Enabled = openCorpses.Checked = Config.GetBool( "AutoOpenCorpses" );
			corpseRange.Text = Config.GetInt( "CorpseRange" ).ToString();

			actionStatusMsg.Checked = Config.GetBool( "ActionStatusMsg" );
			autoStackRes.Checked = Config.GetBool( "AutoStack" );

			rememberPwds.Checked = Config.GetBool( "RememberPwds" );
			filterSnoop.Checked = Config.GetBool( "FilterSnoopMsg" );
			
			preAOSstatbar.Checked = Config.GetBool( "OldStatBar" );
			showtargtext.Checked = Config.GetBool( "LastTargTextFlags" );
			smartLT.Checked = Config.GetBool( "SmartLastTarget" );

			smartCPU.Checked = Config.GetBool( "SmartCPU" );

			autoFriend.Checked = Config.GetBool( "AutoFriend" );

			flipVidHoriz.Checked = Config.GetBool( "FlipVidH" );
			flipVidVert.Checked = Config.GetBool( "FlipVidV" );

			try
			{
				clientPrio.SelectedItem = Config.GetString( "ClientPrio" );
			}
			catch
			{
				clientPrio.SelectedItem = "Normal";
			}
			
			forceSizeX.Text = Config.GetInt( "ForceSizeX" ).ToString();
			forceSizeY.Text = Config.GetInt( "ForceSizeY" ).ToString();

			gameSize.Checked = Config.GetBool( "ForceSizeEnabled" );

			potionEquip.Checked = Config.GetBool( "PotionEquip" );
			blockHealPoison.Checked = Config.GetBool( "BlockHealPoison" );

			negotiate.Checked = Config.GetBool( "Negotiate" );

			logPackets.Checked = Config.GetBool( "LogPacketsByDefault" );

			healthFmt.Enabled = showHealthOH.Checked = Config.GetBool( "ShowHealth" );
			healthFmt.Text = Config.GetString( "HealthFmt" );
			chkPartyOverhead.Checked = Config.GetBool( "ShowPartyStats" );
			
			if ( smartCPU.Checked )
				ClientCommunication.ClientProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.Normal;

			dressList.SelectedIndex = -1;
			hotkeyTree.SelectedNode = null;

			m_Initializing = false;
		}

		private void tabs_IndexChanged(object sender, System.EventArgs e)
		{
			if ( tabs == null )
				return;

			if ( tabs.SelectedTab == generalTab )
			{
				Filters.Filter.Draw( filters );
				langSel.BeginUpdate();
				langSel.Items.Clear();
				langSel.Items.AddRange( Language.GetPackNames() );
				langSel.SelectedItem = Language.Current;
				langSel.EndUpdate();
			}
			else if ( tabs.SelectedTab == skillsTab )
			{
				RedrawSkills();
			}
			else if ( tabs.SelectedTab == displayTab )
			{
				Counter.Redraw( counters );
			}
			else if ( tabs.SelectedTab == dressTab )
			{
				int sel = dressList.SelectedIndex;
				dressItems.Items.Clear();
				DressList.Redraw( dressList );
				if ( sel >= 0 && sel < dressList.Items.Count )
					dressList.SelectedIndex = sel;
			}
			else if ( tabs.SelectedTab == hotkeysTab )
			{
				hotkeyTree.SelectedNode = null;
				HotKey.Status = hkStatus;
				if ( hotkeyTree.TopNode != null )
					hotkeyTree.TopNode.Expand();
				else
					HotKey.RebuildList( hotkeyTree );
			}
			else if ( tabs.SelectedTab == agentsTab )
			{
				int sel = agentList.SelectedIndex;
				Agent.Redraw( agentList, agentGroup, agentB1, agentB2, agentB3, agentB4, agentB5, agentB6 );
				if ( sel >= 0 && sel < agentList.Items.Count )
					agentList.SelectedIndex = sel;
			}
			else if ( tabs.SelectedTab == statusTab )
			{
				UpdateRazorStatus();
			}
			else if ( tabs.SelectedTab == macrosTab )
			{
				RedrawMacros();
				
				if ( MacroManager.Playing || MacroManager.Recording )
					OnMacroStart( MacroManager.Current );
				else
					OnMacroStop();

				if ( MacroManager.Current != null )
					MacroManager.Current.DisplayTo( actionList );

				macroActGroup.Visible = macroTree.SelectedNode != null;
			}
			else if ( tabs.SelectedTab == screenshotTab )
			{
				ReloadScreenShotsList();
			}
		}

		private Version m_Ver = System.Reflection.Assembly.GetCallingAssembly().GetName().Version;

		private uint m_OutPrev;
		private uint m_InPrev;

		private class StatsTimer : Timer
		{
			MainForm m_Form;
			public StatsTimer( MainForm form ) : base( TimeSpan.FromSeconds( 0.5 ), TimeSpan.FromSeconds( 0.5 ) )
			{
				m_Form = form;
			}

			protected override void OnTick()
			{
				m_Form.UpdateRazorStatus();
			}
		}

		private void UpdateRazorStatus()
		{
			if ( !ClientCommunication.ClientRunning )
				Close();

			uint ps = m_OutPrev;
			uint pr = m_InPrev;
			m_OutPrev = ClientCommunication.TotalOut();
			m_InPrev = ClientCommunication.TotalIn();

			if ( tabs.SelectedTab != statusTab )
				return;

			int time = 0;
			if ( ClientCommunication.ConnectionStart != DateTime.MinValue )
				time = (int)((DateTime.Now - ClientCommunication.ConnectionStart).TotalSeconds);

			if (String.IsNullOrEmpty(statusBox.SelectedText))
			{
				statusBox.Lines = Language.Format(LocString.RazorStatus1,
					m_Ver,
					Utility.FormatSize(System.GC.GetTotalMemory(false)),
					Utility.FormatSize(m_OutPrev), Utility.FormatSize((long)((m_OutPrev - ps))),
					Utility.FormatSize(m_InPrev), Utility.FormatSize((long)((m_InPrev - pr))),
					Utility.FormatTime(time),
					(World.Player != null ? (uint)World.Player.Serial : 0),
					(World.Player != null && World.Player.Backpack != null ? (uint)World.Player.Backpack.Serial : 0),
					World.Items.Count,
					World.Mobiles.Count).Split('\n');

				if (World.Player != null)
					statusBox.AppendText(String.Format("\r\nCoordinates: {0} {1} {2}", World.Player.Position.X, World.Player.Position.Y, World.Player.Position.Z));
			}

			if ( PacketHandlers.PlayCharTime < DateTime.Now && PacketHandlers.PlayCharTime+TimeSpan.FromSeconds( 30 ) > DateTime.Now )
			{
				if ( Config.GetBool( "Negotiate" ) )
				{
					bool allAllowed = true;
					StringBuilder text = new StringBuilder();

					text.Append( Language.GetString( LocString.NegotiateTitle ) );
					text.Append( "\r\n" );

					for (uint i=0;i<FeatureBit.MaxBit;i++)
					{
						if ( !ClientCommunication.AllowBit( i ) )
						{
							allAllowed = false;

							text.Append( Language.GetString( (LocString)( ((int)LocString.FeatureDescBase) + i ) ) );
							text.Append( ' ' );
							text.Append( Language.GetString( LocString.NotAllowed ) );
							text.Append( "\r\n" );
						}
					}

					if ( allAllowed )
						text.Append( Language.GetString( LocString.AllFeaturesEnabled ) );

					text.Append( "\r\n" );

					features.Visible = true;
					features.Text = text.ToString();
				}
				else
				{
					features.Visible = false;
				}
			}
		}

		public void UpdateSkill( Skill skill )
		{
			double Total = 0;
			for (int i=0;i<Skill.Count;i++)
				Total += World.Player.Skills[i].Base;
			baseTotal.Text = String.Format( "{0:F1}", Total );

			for (int i=0;i<skillList.Items.Count;i++)
			{
				ListViewItem cur = skillList.Items[i];
				if ( cur.Tag == skill )
				{
					cur.SubItems[1].Text = String.Format( "{0:F1}", skill.Value );
					cur.SubItems[2].Text = String.Format( "{0:F1}", skill.Base );
					cur.SubItems[3].Text = String.Format( "{0}{1:F1}", (skill.Delta > 0 ? "+" : ""), skill.Delta );
					cur.SubItems[4].Text = String.Format( "{0:F1}", skill.Cap );
					cur.SubItems[5].Text = skill.Lock.ToString()[0].ToString();
					SortSkills();
					return;
				}
			}
		}

		public void RedrawSkills()
		{
			skillList.BeginUpdate();
			skillList.Items.Clear();
			double Total = 0;
			if ( World.Player != null && World.Player.SkillsSent )
			{
				string [] items = new string[6];
				for (int i=0;i<Skill.Count;i++)
				{
					Skill sk = World.Player.Skills[i];
					Total += sk.Base;
					items[0] = Language.Skill2Str( i );//((SkillName)i).ToString();
					items[1] = String.Format( "{0:F1}", sk.Value );
					items[2] = String.Format( "{0:F1}", sk.Base );
					items[3] = String.Format( "{0}{1:F1}", (sk.Delta > 0 ? "+" : ""), sk.Delta );
					items[4] = String.Format( "{0:F1}", sk.Cap );
					items[5] = sk.Lock.ToString()[0].ToString();

					ListViewItem lvi = new ListViewItem( items );
					lvi.Tag = sk;
					skillList.Items.Add( lvi );
				}

				//Config.SetProperty( "SkillListAsc", false );
				SortSkills();
			}
			skillList.EndUpdate();
			baseTotal.Text = String.Format( "{0:F1}", Total );
		}

		private void OnFilterCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			((Filter)filters.Items[e.Index]).OnCheckChanged( e.NewValue );
		}

		private void incomingMob_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ShowMobNames", incomingMob.Checked );
		}

		private void incomingCorpse_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ShowCorpseNames", incomingCorpse.Checked );
		}

		private ContextMenu m_SkillMenu ;
		private void skillList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Right )
			{
				ListView.SelectedListViewItemCollection items = skillList.SelectedItems;
				if ( items.Count <= 0 )
					return;
				Skill s = items[0].Tag as Skill;
				if ( s == null )
					return;

				if ( m_SkillMenu == null )
				{
					m_SkillMenu = new ContextMenu( new MenuItem[]
					{
						new MenuItem( Language.GetString( LocString.SetSLUp ), new EventHandler( onSetSkillLockUP ) ),
						new MenuItem( Language.GetString( LocString.SetSLDown ), new EventHandler( onSetSkillLockDOWN ) ),
						new MenuItem( Language.GetString( LocString.SetSLLocked ), new EventHandler( onSetSkillLockLOCKED ) ),
					} );
				}

				for (int i=0;i<3;i++)
					m_SkillMenu.MenuItems[i].Checked = ((int)s.Lock) == i;

				m_SkillMenu.Show( skillList, new Point( e.X, e.Y ) );
			}
		}

		private void onSetSkillLockUP(object sender, EventArgs e)
		{
			SetLock( LockType.Up );
		}

		private void onSetSkillLockDOWN(object sender, EventArgs e)
		{
			SetLock( LockType.Down );
		}

		private void onSetSkillLockLOCKED(object sender, EventArgs e)
		{
			SetLock( LockType.Locked );
		}

		private void SetLock( LockType lockType )
		{
			ListView.SelectedListViewItemCollection items = skillList.SelectedItems;
			if ( items.Count <= 0 )
				return;
			Skill s = items[0].Tag as Skill;
			if ( s == null )
				return;
			
			try
			{
				ClientCommunication.SendToServer( new SetSkillLock( s.Index, lockType ) );

				s.Lock = lockType;
				UpdateSkill( s );

				ClientCommunication.SendToClient( new SkillUpdate( s ) );
			}
			catch
			{
			}
			
		}

		private void OnSkillColClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if ( e.Column == Config.GetInt( "SkillListCol" ) )
				Config.SetProperty( "SkillListAsc", !Config.GetBool( "SkillListAsc" ) );
			else
				Config.SetProperty( "SkillListCol", e.Column );
			SortSkills();
		}

		private void SortSkills()
		{
			int col = Config.GetInt( "SkillListCol" );
			bool asc = Config.GetBool( "SkillListAsc" );

			if ( col < 0 || col > 5 )
				col = 0;

			skillList.BeginUpdate();
			if ( col == 0 || col == 5 )
			{
				skillList.ListViewItemSorter = null;
				skillList.Sorting = asc ? SortOrder.Ascending : SortOrder.Descending;
			}
			else
			{
				LVDoubleComparer.Column = col;
				LVDoubleComparer.Asc = asc;
				
				skillList.ListViewItemSorter = LVDoubleComparer.Instance;
					
				skillList.Sorting = SortOrder.None;
				skillList.Sort();
			}
			skillList.EndUpdate();
			skillList.Refresh();
		}

		private class LVDoubleComparer : IComparer
		{
			public static readonly LVDoubleComparer Instance = new LVDoubleComparer();
			public static int Column { set{ Instance.m_Col = value; } }
			public static bool Asc{ set{ Instance.m_Asc = value; } }

			private int m_Col;
			private bool m_Asc;

			private LVDoubleComparer()
			{
			}

			public int Compare( object x, object y )
			{
				if ( x == null || !(x is ListViewItem) )
					return m_Asc ? 1 : -1;
				else if ( y == null || !(y is ListViewItem) )
					return m_Asc ? -1 : 1;

				try
				{
					double dx = Convert.ToDouble( ((ListViewItem)x).SubItems[m_Col].Text );
					double dy = Convert.ToDouble( ((ListViewItem)y).SubItems[m_Col].Text );

					if ( dx > dy ) 
						return m_Asc ? -1 : 1;
					else if ( dx == dy ) 
						return 0;
					else //if ( dx > dy )
						return m_Asc ? 1 : -1;
				}
				catch 
				{
					return ((ListViewItem)x).Text.CompareTo( ((ListViewItem)y).Text ) * ( m_Asc ? 1 : -1 );
				}
			}
		}

		private void OnResetSkillDelta(object sender, System.EventArgs e)
		{
			if ( World.Player == null )
				return;

			for (int i=0;i<Skill.Count;i++)
				World.Player.Skills[i].Delta = 0;

			RedrawSkills();
		}

		private void OnSetSkillLocks(object sender, System.EventArgs e)
		{
			if ( locks.SelectedIndex == -1 || World.Player == null )
				return;

			LockType type = (LockType)locks.SelectedIndex;

			for (short i=0;i<Skill.Count;i++)
			{
				World.Player.Skills[i].Lock = type;
				ClientCommunication.SendToServer( new SetSkillLock( i, type ) );
			}
			ClientCommunication.SendToClient( new SkillsList() );
			RedrawSkills();
		}

		private void OnDispSkillCheck(object sender, System.EventArgs e)
		{
			Config.SetProperty( "DispSkillChanges", dispDelta.Checked );
		}

		private void delCounter_Click(object sender, System.EventArgs e)
		{
			if ( counters.SelectedItems.Count <= 0 )
				return;

			Counter c = counters.SelectedItems[0].Tag as Counter;

			if ( c != null )
			{
				AddCounter ac = new AddCounter( c );
				switch ( ac.ShowDialog( this ) )
				{
					case DialogResult.Abort:
						counters.Items.Remove( c.ViewItem );
						Counter.List.Remove( c );
						break;

					case DialogResult.OK:
						c.Set( (ushort)ac.ItemID, ac.Hue, ac.NameStr, ac.FmtStr, ac.DisplayImage );
						break;
				}
			}
		}

		private void addCounter_Click(object sender, System.EventArgs e)
		{
			AddCounter dlg = new AddCounter();

			if ( dlg.ShowDialog( this ) == DialogResult.OK )
			{
				Counter.Register( new Counter( dlg.NameStr, dlg.FmtStr, (ushort)dlg.ItemID, (int)dlg.Hue, dlg.DisplayImage ) );
				Counter.Redraw( counters );
			}
		}

		private void showInBar_CheckedChanged(object sender, System.EventArgs e)
		{
			titleStr.Enabled = showInBar.Checked;
			Config.SetProperty( "TitleBarDisplay", showInBar.Checked );
			ClientCommunication.RequestTitlebarUpdate();
		}

		private void titleStr_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "TitleBarText", titleStr.Text.TrimEnd() );
			if ( Config.GetBool( "TitleBarDisplay" ) )
				ClientCommunication.RequestTitlebarUpdate();
		}

		private void counters_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			if ( e.Index >= 0 && e.Index < Counter.List.Count && !Counter.SupressChecks )
			{
				((Counter)(counters.Items[e.Index].Tag)).SetEnabled( e.NewValue == CheckState.Checked );
				ClientCommunication.RequestTitlebarUpdate();
				counters.Sort();
				//counters.Refresh();
			}
		}

		public void RedrawCounters()
		{
			Counter.Redraw( counters );
		}

		private void checkNewConts_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoSearch", checkNewConts.Checked );
			excludePouches.Enabled = checkNewConts.Checked;
		}

		private void warnCount_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CounterWarn", warnCount.Checked );
			warnNum.Enabled = warnCount.Checked;
		}

		private void timerTimer_Tick(object sender, System.EventArgs e)
		{
			Timer.Control = timerTimer;
			Timer.Slice();
		}

		private void warnNum_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CounterWarnAmount", Utility.ToInt32( warnNum.Text.Trim(), 3 ) );
		}

		private void alwaysTop_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AlwaysOnTop", this.TopMost = alwaysTop.Checked );
		}

		private void profiles_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if ( profiles.SelectedIndex < 0 || !m_ProfileConfirmLoad )
				return;

			string name = (string)profiles.Items[profiles.SelectedIndex];
			if ( MessageBox.Show( this, Language.Format( LocString.ProfLoadQ, name ), "Load?", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			{
				Config.Save();
				if ( !Config.LoadProfile( name ) )
				{
					MessageBox.Show( this, Language.GetString( LocString.ProfLoadE ), "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				}
				else
				{
					InitConfig();
					if ( World.Player != null )
						Config.SetProfileFor( World.Player );
				}
				ClientCommunication.RequestTitlebarUpdate();
			}
			else
			{
				m_ProfileConfirmLoad = false;
				for (int i=0;i<profiles.Items.Count;i++)
				{
					if ( (string)profiles.Items[i] == Config.CurrentProfile.Name )
					{
						profiles.SelectedIndex = i;
						break;
					}
				}
				m_ProfileConfirmLoad = true;
			}
		}

		private void delProfile_Click(object sender, System.EventArgs e)
		{
			if ( profiles.SelectedIndex < 0 )
				return;
			string remove = (string)profiles.Items[profiles.SelectedIndex];

			if ( remove == "default" )
			{
				MessageBox.Show( this, Language.GetString( LocString.NoDelete ), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			string file = String.Format( "Profiles/{0}.xml", remove );
			if ( File.Exists( file ) )
				File.Delete( file );

			profiles.Items.Remove( remove );
			if ( !Config.LoadProfile( "default" ) )
			{
				Config.CurrentProfile.MakeDefault();
				Config.CurrentProfile.Name = "default";
			}
			InitConfig();

			m_ProfileConfirmLoad = false;
			for (int i=0;i<profiles.Items.Count;i++)
			{
				if ( (string)profiles.Items[i] == "default" )
				{
					profiles.SelectedIndex = i;
					m_ProfileConfirmLoad = true;
					return;
				}
			}

			int sel = profiles.Items.Count;
			profiles.Items.Add( "default" );
			profiles.SelectedIndex = sel;
			m_ProfileConfirmLoad = true;
		}

		public void SelectProfile( string name )
		{
			m_ProfileConfirmLoad = false;
			profiles.SelectedItem = name;
			m_ProfileConfirmLoad = true;
		}

		private void newProfile_Click(object sender, System.EventArgs e)
		{
			if ( InputBox.Show( this, Language.GetString( LocString.EnterProfileName ), Language.GetString( LocString.EnterAName ) ) )
			{
				string str = InputBox.GetString();
				if ( str == null || str == "" || str.IndexOfAny( Path.GetInvalidPathChars() ) != -1 || str.IndexOfAny( m_InvalidNameChars ) != -1 )
				{
					MessageBox.Show( this, Language.GetString( LocString.InvalidChars ), Language.GetString( LocString.Invalid ), MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}

				m_ProfileConfirmLoad = false;
				int sel = profiles.Items.Count;
				string lwr = str.ToLower();
				for (int i=0;i<profiles.Items.Count;i++)
				{
					if ( lwr == ((string)profiles.Items[i]).ToLower() )
					{
						if ( MessageBox.Show( this, Language.GetString( LocString.ProfExists ), "Load Profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
						{
							Config.Save();
							profiles.SelectedIndex = i;
							if ( !Config.LoadProfile( str ) )
							{
								MessageBox.Show( this, Language.GetString( LocString.ProfLoadE ), "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
							}
							else
							{
								InitConfig();
								if ( World.Player != null )
									Config.SetProfileFor( World.Player );
							}
							ClientCommunication.RequestTitlebarUpdate();
						}

						m_ProfileConfirmLoad = true;
						return;
					}
				}

				Config.Save();
				Config.NewProfile( str );
				profiles.Items.Add( str );
				profiles.SelectedIndex = sel;
				InitConfig();
				if ( World.Player != null )
					Config.SetProfileFor( World.Player );
				m_ProfileConfirmLoad = true;
			}
		}

		public bool CanClose
		{
			get
			{ 
				return m_CanClose; 
			}
			set
			{
				m_CanClose = value;
			}
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ( !m_CanClose && ClientCommunication.ClientRunning )
			{
				DisableCloseButton();
				e.Cancel = true;
			}
			else
			{
				PacketPlayer.Stop();
				AVIRec.Stop();
			}
			//if ( Engine.NoPatch )
			//	e.Cancel = MessageBox.Show( this, "Are you sure you want to close Razor?\n(This will not close the UO client.)", "Close Razor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No;
		}

		private void skillCopySel_Click(object sender, System.EventArgs e)
		{
			if ( skillList.SelectedItems == null || skillList.SelectedItems.Count <= 0 )
				return;

			StringBuilder sb = new StringBuilder();
			for (int i=0;i<skillList.SelectedItems.Count;i++)
			{
				ListViewItem vi = skillList.SelectedItems[i];
				if ( vi != null && vi.SubItems != null && vi.SubItems.Count > 4 )
				{
					string name = vi.SubItems[0].Text;
					if ( name != null && name.Length > 20 )
						name = name.Substring( 0, 16 ) + "...";
					
					sb.AppendFormat( "{0,-20} {1,5:F1} {2,5:F1} {4:F1} {5,5:F1}\n", 
						name, 
						vi.SubItems[1].Text, 
						vi.SubItems[2].Text, 
						Utility.ToInt32( vi.SubItems[3].Text, 0 ) < 0 ? "" : "+", 
						vi.SubItems[3].Text, 
						vi.SubItems[4].Text );
				}
			}

			if ( sb.Length > 0 )
				Clipboard.SetDataObject( sb.ToString(), true );
		}

		private void skillCopyAll_Click(object sender, System.EventArgs e)
		{
			if ( World.Player == null )
				return;

			StringBuilder sb = new StringBuilder();
			for (int i=0;i<Skill.Count;i++)
			{
				Skill sk = World.Player.Skills[i];
				sb.AppendFormat( "{0,-20} {1,-5:F1} {2,-5:F1} {3}{4,-5:F1} {5,-5:F1}\n", (SkillName)i, sk.Value, sk.Base, sk.Delta > 0 ? "+":"", sk.Delta, sk.Cap );
			}

			if ( sb.Length > 0 )
				Clipboard.SetDataObject( sb.ToString(), true );
		}

		private void addDress_Click(object sender, System.EventArgs e)
		{
			if ( InputBox.Show( this, Language.GetString( LocString.DressName ), Language.GetString( LocString.EnterAName ) ) )
			{
				string str = InputBox.GetString();
				if ( str == null || str == "" )
					return;
				DressList list = new DressList( str );
				DressList.Add( list );
				dressList.Items.Add( list );
				dressList.SelectedItem = list;
			}
		}
		
		private void removeDress_Click(object sender, System.EventArgs e)
		{
			DressList dress = (DressList)dressList.SelectedItem;

			if ( dress != null && MessageBox.Show( this, Language.GetString( LocString.DelDressQ ), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			{
				dress.Items.Clear();
				dressList.Items.Remove( dress );
				dressList.SelectedIndex = -1;
				dressItems.Items.Clear();
				DressList.Remove( dress );
			}
		}

		private void dressNow_Click(object sender, System.EventArgs e)
		{
			DressList dress = (DressList)dressList.SelectedItem;
			if ( dress != null && World.Player != null )
				dress.Dress();
		}
		
		private void undressList_Click(object sender, System.EventArgs e)
		{
			DressList dress = (DressList)dressList.SelectedItem;
			if ( dress != null && World.Player != null && World.Player.Backpack != null )
				dress.Undress();
		}

		private void targItem_Click(object sender, System.EventArgs e)
		{
			Targeting.OneTimeTarget( new Targeting.TargetResponseCallback( OnDressItemTarget ) );
		}

		private void OnDressItemTarget( bool loc, Serial serial, Point3D pt, ushort itemid )
		{
			if ( loc )
				return;

			ShowMe();
			if ( serial.IsItem )
			{
				DressList list = (DressList)dressList.SelectedItem;

				if ( list == null  )
					return;

				list.Items.Add( serial );
				Item item = World.FindItem( serial );

				if ( item == null )
					dressItems.Items.Add( Language.Format( LocString.OutOfRangeA1, serial ) );
				else
					dressItems.Items.Add( item.ToString() );
			}
		}

		private void dressDelSel_Click(object sender, System.EventArgs e)
		{
			DressList list = (DressList)dressList.SelectedItem;
			if ( list == null )
				return;

			int sel = dressItems.SelectedIndex;
			if ( sel < 0 || sel >= list.Items.Count ) 
				return;

			if ( MessageBox.Show( this, Language.GetString( LocString.DelDressItemQ ), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			{
				try
				{
					list.Items.RemoveAt( sel );
					dressItems.Items.RemoveAt( sel );
				}
				catch
				{
				}
			}
		}
		
		private void clearDress_Click(object sender, System.EventArgs e)
		{
			DressList list = (DressList)dressList.SelectedItem;
			if ( list == null )
				return;

			list.Items.Clear();
			dressItems.Items.Clear();
		}

		private DressList undressBagList = null;
		private void undressBag_Click(object sender, System.EventArgs e)
		{
			if ( World.Player == null )
				return;

			DressList list = (DressList)dressList.SelectedItem;
			if ( list == null )
				return;

			undressBagList = list;
			Targeting.OneTimeTarget( new Targeting.TargetResponseCallback( onDressBagTarget ) );
			World.Player.SendMessage( MsgLevel.Force, LocString.TargUndressBag, list.Name );
		}

		void onDressBagTarget( bool location, Serial serial, Point3D p, ushort gfxid )
		{
			if ( undressBagList == null )
				return;

			ShowMe();
			if ( serial.IsItem )
			{
				Item item = World.FindItem( serial );
				if ( item != null )
				{
					undressBagList.SetUndressBag( item.Serial );
					World.Player.SendMessage( MsgLevel.Force, LocString.UB_Set );
				}
				else
				{
					undressBagList.SetUndressBag( Serial.Zero );
					World.Player.SendMessage( MsgLevel.Force, LocString.ItemNotFound );
				}
			}
			else
			{
				World.Player.SendMessage( MsgLevel.Force, LocString.ItemNotFound );
			}

			undressBagList = null;
		}

		private void dressList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DressList list = (DressList)dressList.SelectedItem;

			dressItems.BeginUpdate();
			dressItems.Items.Clear();
			if ( list != null  )
			{
				for (int i=0;i<list.Items.Count;i++)
				{
					if ( list.Items[i] is Serial )
					{
						Serial serial = (Serial)list.Items[i];
						Item item = World.FindItem( serial );

						if ( item != null )
							dressItems.Items.Add( item.ToString() );
						else
							dressItems.Items.Add( Language.Format( LocString.OutOfRangeA1, serial ) );
					}
					else if ( list.Items[i] is ItemID )
					{
						dressItems.Items.Add( list.Items[i].ToString() );
					}
				}
			}
			dressItems.EndUpdate();
		}

		private void dressUseCur_Click(object sender, System.EventArgs e)
		{
			DressList list = (DressList)dressList.SelectedItem;
			if ( World.Player == null )
				return;
			if ( list == null )
				return;

			for ( int i=0;i<World.Player.Contains.Count;i++ )
			{
				Item item = (Item)World.Player.Contains[i];
				if ( item.Layer <= Layer.LastUserValid && item.Layer != Layer.Backpack && item.Layer != Layer.Hair && item.Layer != Layer.FacialHair )
					list.Items.Add( item.Serial );
			}
			dressList.SelectedItem = null;
			dressList.SelectedItem = list;
		}

		private void hotkeyTree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			ClearHKCtrls();

			if ( e.Node == null || !(e.Node.Tag is KeyData ) )
				return;
			KeyData hk = (KeyData)e.Node.Tag;

			try
			{
				m_LastKV = hk.Key;
				switch ( hk.Key )
				{
					case -1:
						key.Text = ( "MouseWheel UP" );
						break;
					case -2:
						key.Text = ( "MouseWheel DOWN" );
						break;
					case -3:
						key.Text = ( "Mouse MID Button" );
						break;
					case -4:
						key.Text = ( "Mouse XButton 1" );
						break;
					case -5:
						key.Text = ( "Mouse XButton 2" );
						break;
					default:
						if ( hk.Key > 0 && hk.Key < 256 )
							key.Text = ( ((Keys)hk.Key).ToString() );
						else
							key.Text = ( "" );
						break;
				}
			}
			catch
			{
				key.Text = ">>ERROR<<";
			}

			chkCtrl.Checked = (hk.Mod&ModKeys.Control) != 0;
			chkAlt.Checked = (hk.Mod&ModKeys.Alt) != 0;
			chkShift.Checked = (hk.Mod&ModKeys.Shift)!= 0;
			chkPass.Checked = hk.SendToUO;

			if ( ( hk.LocName >= (int)LocString.DrinkHeal && hk.LocName <= (int)LocString.DrinkAg && !ClientCommunication.AllowBit( FeatureBit.PotionHotkeys ) ) || 
				( hk.LocName >= (int)LocString.TargCloseRed && hk.LocName <= (int)LocString.TargCloseCriminal && !ClientCommunication.AllowBit( FeatureBit.ClosestTargets ) ) ||
				( (( hk.LocName >= (int)LocString.TargRandRed && hk.LocName <= (int)LocString.TargRandNFriend ) ||
				( hk.LocName >= (int)LocString.TargRandEnemyHuman && hk.LocName <= (int)LocString.TargRandCriminal)) && !ClientCommunication.AllowBit( FeatureBit.RandomTargets ) ) )
			{
				LockControl( chkCtrl );
				LockControl( chkAlt );
				LockControl( chkShift );
				LockControl( chkPass );
				LockControl( key );
				LockControl( unsetHK );
				LockControl( setHK );
				LockControl( dohotkey );
			}
		}

		private KeyData GetSelectedHK()
		{
			if ( hotkeyTree != null && hotkeyTree.SelectedNode != null )
				return hotkeyTree.SelectedNode.Tag as KeyData;
			else
				return null;
		}

		private void ClearHKCtrls()
		{
			m_LastKV = 0;
			key.Text = "";
			chkCtrl.Checked = false;
			chkAlt.Checked = false;
			chkShift.Checked = false;
			chkPass.Checked = false;

			UnlockControl( chkCtrl );
			UnlockControl( chkAlt );
			UnlockControl( chkShift );
			UnlockControl( chkPass );
			UnlockControl( key );
			UnlockControl( unsetHK );
			UnlockControl( setHK );
			UnlockControl( dohotkey );
		}

		private void setHK_Click(object sender, System.EventArgs e)
		{
			KeyData hk = GetSelectedHK();
			if ( hk == null || m_LastKV == 0  )
				return;

			ModKeys mod = ModKeys.None;
			if ( chkCtrl.Checked )
				mod |= ModKeys.Control;
			if ( chkAlt.Checked )
				mod |= ModKeys.Alt;
			if ( chkShift.Checked )
				mod |= ModKeys.Shift;

			KeyData g = HotKey.Get( m_LastKV, mod );
			bool block = false;
			if ( g != null && g != hk )
			{
				if ( MessageBox.Show( this, Language.Format( LocString.KeyUsed, g.DispName, hk.DispName ), "Hot Key Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
				{
					g.Key = 0;
					g.Mod = ModKeys.None;
					g.SendToUO = false;
				}
				else
				{
					block = true;
				}
			}

			if ( !block )
			{
				hk.Key = m_LastKV;
				hk.Mod = mod;

				hk.SendToUO = chkPass.Checked;
			}
		}

		private void unsetHK_Click(object sender, System.EventArgs e)
		{
			KeyData hk = GetSelectedHK();
			if ( hk == null )
				return;

			hk.Key = 0;
			hk.Mod = 0;
			hk.SendToUO = false;

			ClearHKCtrls();
		}

		private void key_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			m_LastKV = (int)e.KeyCode;
			key.Text = e.KeyCode.ToString();
			
			e.Handled = true;
		}

		private void key_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Delta > 0 )
			{
				m_LastKV = -1;
				key.Text = "MouseWheel UP";
			}
			else if ( e.Delta < 0 )
			{
				m_LastKV = -2;
				key.Text = "MouseWheel DOWN";
			}
		}

		private void key_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Middle )
			{
				m_LastKV = -3;
				key.Text = "Mouse MID Button";
			}
			else if ( e.Button == MouseButtons.XButton1 )
			{
				m_LastKV = -4;
				key.Text = "Mouse XButton 1";
			}
			else if ( e.Button == MouseButtons.XButton2 )
			{
				m_LastKV = -5;
				key.Text = "Mouse XButton 2";
			}
		}
		
		private void dohotkey_Click(object sender, System.EventArgs e)
		{
			KeyData hk = GetSelectedHK();
			if ( hk != null && World.Player != null )
			{
				if ( MacroManager.AcceptActions )
					MacroManager.Action( new HotKeyAction( hk ) );
				hk.Callback();
			}
		}

		private void queueTargets_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "QueueTargets", queueTargets.Checked );
		}

		private void chkForceSpeechHue_CheckedChanged(object sender, System.EventArgs e)
		{
			setSpeechHue.Enabled = chkForceSpeechHue.Checked;
			Config.SetProperty( "ForceSpeechHue", chkForceSpeechHue.Checked );
		}

		private void lthilight_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( !(setLTHilight.Enabled = lthilight.Checked) )
			{
				Config.SetProperty( "LTHilight", 0 );
				ClientCommunication.SetCustomNotoHue( 0 );
				lthilight.BackColor = SystemColors.Control;
				lthilight.ForeColor = SystemColors.ControlText;
			}
		}

		private void chkForceSpellHue_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkForceSpellHue.Checked )
			{
				setBeneHue.Enabled = setHarmHue.Enabled = setNeuHue.Enabled = true;
				Config.SetProperty( "ForceSpellHue", true );
			}
			else
			{
				setBeneHue.Enabled = setHarmHue.Enabled = setNeuHue.Enabled = false;
				Config.SetProperty( "ForceSpellHue", false );
			}
		}

		private void txtSpellFormat_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "SpellFormat", txtSpellFormat.Text.Trim() );
		}

		private void InitPreviewHue( Control ctrl, string cfg )
		{
			int hueIdx = Config.GetInt( cfg );
			if ( hueIdx > 0 && hueIdx < 3000 )
				ctrl.BackColor = Ultima.Hues.GetHue( hueIdx - 1 ).GetColor( HueEntry.TextHueIDX );
			else
				ctrl.BackColor = SystemColors.Control;
			ctrl.ForeColor = ( ctrl.BackColor.GetBrightness() < 0.35 ? Color.White : Color.Black );
		}

		private bool SetHue( Control ctrl, string cfg )
		{
			HueEntry h = new HueEntry( Config.GetInt( cfg ) );

			if ( h.ShowDialog( this ) == DialogResult.OK )
			{
				int hueIdx = h.Hue;
				Config.SetProperty( cfg, hueIdx );
				if ( hueIdx > 0 && hueIdx < 3000 )
					ctrl.BackColor = Ultima.Hues.GetHue( hueIdx - 1 ).GetColor( HueEntry.TextHueIDX );
				else
					ctrl.BackColor = Color.White;
				ctrl.ForeColor = ( ctrl.BackColor.GetBrightness() < 0.35 ? Color.White : Color.Black );

				return true;
			}
			else
			{
				return false;
			}
		}

		private void setExHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblExHue, "ExemptColor" );
		}

		private void setMsgHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblMsgHue, "SysColor" );
		}

		private void setWarnHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblWarnHue, "WarningColor" );
		}

		private void setSpeechHue_Click(object sender, System.EventArgs e)
		{
			SetHue( chkForceSpeechHue, "SpeechHue" );
		}

		private void setLTHilight_Click(object sender, System.EventArgs e)
		{
			if ( SetHue( lthilight, "LTHilight" ) )
				ClientCommunication.SetCustomNotoHue( Config.GetInt( "LTHilight" ) );
		}

		private void setBeneHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblBeneHue, "BeneficialSpellHue" );
		}

		private void setHarmHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblHarmHue, "HarmfulSpellHue" );
		}

		private void setNeuHue_Click(object sender, System.EventArgs e)
		{
			SetHue( lblNeuHue, "NeutralSpellHue" );
		}

		private void QueueActions_CheckedChanged(object sender, System.EventArgs e)
		{
			//txtObjDelay.Enabled = QueueActions.Checked;
			Config.SetProperty( "QueueActions", QueueActions.Checked );
		}

		private void txtObjDelay_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ObjectDelay", Utility.ToInt32( txtObjDelay.Text.Trim(), 500 ) );
		}

		private void chkStealth_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CountStealthSteps", chkStealth.Checked );
		}

		private void agentList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				Agent.Select( agentList.SelectedIndex, agentList, agentSubList, agentGroup, agentB1, agentB2, agentB3, agentB4, agentB5, agentB6 );
			}
			catch
			{
			}
		}

		private void Agent_Button( int b )
		{
			if ( World.Player == null )
				return;

			Agent a = agentList.SelectedItem as Agent;
			if ( a == null )
				agentList.SelectedIndex = -1;
			else
				a.OnButtonPress( b );
		}

		private void agentB1_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 1 );
		}

		private void agentB2_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 2 );
		}

		private void agentB3_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 3 );
		}

		private void agentB4_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 4 );
		}

		private void agentB5_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 5 );
		}

		private void agentB6_Click(object sender, System.EventArgs e)
		{
			Agent_Button( 6 );
		}

		private void MainForm_Activated(object sender, System.EventArgs e)
		{
			DisableCloseButton();
			//this.TopMost = true;
		}

		private void MainForm_Deactivate(object sender, System.EventArgs e)
		{
			if ( this.TopMost )
				this.TopMost = false;
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			if ( WindowState == FormWindowState.Minimized && !this.ShowInTaskbar )
				this.Hide();
		}

		private bool IsNear( int a, int b )
		{
			return ( a <= b+5 && a >= b-5 );
		}

		private void MainForm_Move(object sender, System.EventArgs e)
		{
			// atempt to dock to the side of the screen.  Also try not to save the X/Y when we are minimized (which is -32000, -32000)
			System.Drawing.Point pt = this.Location; 

			Rectangle screen = Screen.GetWorkingArea( this );
			if ( this.WindowState != FormWindowState.Minimized && pt.X+this.Width/2 >= screen.Left && pt.Y+this.Height/2 >= screen.Top && pt.X <= screen.Right && pt.Y <= screen.Bottom )
			{
				if ( IsNear( pt.X + this.Width, screen.Right ) )
					pt.X = screen.Right - this.Width;
				else if ( IsNear( pt.X, screen.Left ) )
					pt.X = screen.Left;

				if ( IsNear( pt.Y + this.Height, screen.Bottom ) )
					pt.Y = screen.Bottom - this.Height;
				else if ( IsNear( pt.Y, screen.Top ) )
					pt.Y = screen.Top;

				this.Location = pt;
				Config.SetProperty( "WindowX", (int)pt.X );
				Config.SetProperty( "WindowY", (int)pt.Y );
			}
		}

		private void opacity_Scroll(object sender, System.EventArgs e)
		{
			int o = opacity.Value;
			Config.SetProperty( "Opacity", o );
			opacityLabel.Text = String.Format( "Opacity: {0}%", o );
			this.Opacity = ((double)o) / 100.0;
		}

		private void dispDelta_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "DisplaySkillChanges", dispDelta.Checked );
		}
		
		/*private void saveProfile_Click(object sender, System.EventArgs e)
		{
			Counter.Save();
			Config.Save();
			MacroManager.Save();
			MessageBox.Show( this, Language.GetString( LocString.SaveOK ), "Save OK", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}
		
		private void edit_Click(object sender, System.EventArgs e)
		{
			if ( counters.SelectedItems.Count <= 0 )
				return;

			Counter c = counters.SelectedItems[0].Tag as Counter;
			if ( c == null )
				return;

			AddCounter dlg = new AddCounter( c.Name, c.Format, c.ItemID, c.Hue );

			if ( dlg.ShowDialog( this ) == DialogResult.OK )
			{
				c.Name = dlg.NameStr;
				c.Format = dlg.FmtStr;
				c.ItemID = (ushort)dlg.ItemID;
				c.Hue = (int)dlg.Hue;
				Counter.Redraw( counters );
			}
		}*/

		private void logPackets_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( logPackets.Checked )
			{
				if ( m_Initializing || MessageBox.Show( this, Language.GetString( LocString.PacketLogWarn ), "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes )
					Packet.Logging = true;
				else
					logPackets.Checked = false;
			}
			else
			{
				Packet.Logging = false;
			}
		}

		private void showNotoHue_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ShowNotoHue", showNotoHue.Checked );
			if ( showNotoHue.Checked )
				ClientCommunication.RequestTitlebarUpdate();
		}

		private void recount_Click(object sender, System.EventArgs e)
		{
			Counter.FullRecount();
		}

		private void openCorpses_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoOpenCorpses", openCorpses.Checked );
			corpseRange.Enabled = openCorpses.Checked;
		}

		private void corpseRange_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CorpseRange", Utility.ToInt32( corpseRange.Text, 2 ) );
		}

		private void showWelcome_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetRegString( Microsoft.Win32.Registry.CurrentUser, "ShowWelcome", ( showWelcome.Checked ? 1 : 0 ).ToString() );
		}

		private ContextMenu m_DressItemsMenu = null;
		private void dressItems_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Right )
			{
				m_DressItemsMenu = new ContextMenu( new MenuItem[]{ new MenuItem( Language.GetString( LocString.Conv2Type ), new EventHandler( OnMakeType ) ) } );
				m_DressItemsMenu.Show( dressItems, new Point( e.X, e.Y ) );
			}
		}

		private void OnMakeType( object sender, System.EventArgs e )
		{
			DressList list = (DressList)dressList.SelectedItem;
			if ( list == null ) 
				return;
			int sel = dressItems.SelectedIndex;
			if ( sel < 0 || sel >= list.Items.Count )
				return;

			if ( list.Items[sel] is Serial )
			{
				Serial s = (Serial)list.Items[sel];
				Item item = World.FindItem( s );
				if ( item != null )
				{
					list.Items[sel] = item.ItemID;
					dressItems.BeginUpdate();
					dressItems.Items[sel] = item.ItemID.ToString();
					dressItems.EndUpdate();
				}
			}
		}

		private static char[] m_InvalidNameChars = new char[]{ '/', '\\', ';', '?', ':', '*' };
		private void newMacro_Click(object sender, System.EventArgs e)
		{
			if ( InputBox.Show( this, Language.GetString( LocString.NewMacro ), Language.GetString( LocString.EnterAName ) ) )
			{
				string name = InputBox.GetString();
				if ( name == null || name == "" || name.IndexOfAny( Path.GetInvalidPathChars() ) != -1 || name.IndexOfAny( m_InvalidNameChars ) != -1 )
				{
					MessageBox.Show( this, Language.GetString( LocString.InvalidChars ), Language.GetString( LocString.Invalid ), MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}

				TreeNode node = GetMacroDirNode();
                string path = (node == null || !(node.Tag is string)) ? Config.GetUserDirectory("Macros") : (string)node.Tag;
				path = Path.Combine( path, name+".macro" );
				if ( File.Exists( path ) )
				{
					MessageBox.Show( this, Language.GetString( LocString.MacroExists ), Language.GetString( LocString.Invalid ), MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}

				try
				{
					File.CreateText( path ).Close();
				}
				catch
				{
					return;
				}

				Macro m = new Macro( path );
				MacroManager.Add( m );
				TreeNode newNode = new TreeNode( Path.GetFileNameWithoutExtension( m.Filename ) );
				newNode.Tag = m;
				if ( node == null )
					macroTree.Nodes.Add( newNode );
				else
					node.Nodes.Add( newNode );
				macroTree.SelectedNode = newNode;
			}

			RedrawMacros();
		}

		public Macro GetMacroSel()
		{
			if ( macroTree.SelectedNode == null || !(macroTree.SelectedNode.Tag is Macro) )
				return null;
			else
				return (Macro)macroTree.SelectedNode.Tag;
		}

		public void playMacro_Click(object sender, System.EventArgs e)
		{
			if ( World.Player == null )
				return;

			if ( MacroManager.Playing )
			{
				MacroManager.Stop();
				//OnMacroStop();
			}
			else
			{
				Macro m = GetMacroSel();
				if ( m == null || m.Actions.Count <= 0 )
					return;

				actionList.SelectedIndex = 0;
				MacroManager.Play( m );
				playMacro.Text = "Stop";
				recMacro.Enabled = false;
				OnMacroStart( m );
			}
		}

		private void recMacro_Click(object sender, System.EventArgs e)
		{
			if ( World.Player == null )
				return;

			if ( MacroManager.Recording )
			{
				MacroManager.Stop();
				//OnMacroStop();
			}
			else
			{
				Macro m = GetMacroSel();
				if ( m == null )
					return;

				bool rec = true;
				if ( m.Actions.Count > 0 )
					rec = MessageBox.Show( this, Language.GetString( LocString.MacroConfRec ), "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes;

				if ( rec )
				{
					MacroManager.Record( m );
					OnMacroStart( m );
					recMacro.Text = "Stop";
					playMacro.Enabled = false;
				}
			}
		}

		public void OnMacroStart( Macro m )
		{
			actionList.SelectedIndex = -1;
			macroTree.Enabled = actionList.Enabled = false;
			newMacro.Enabled = delMacro.Enabled = false;
			//macroList.SelectedItem = m;
			macroTree.SelectedNode = FindNode( macroTree.Nodes, m );
			macroTree.Update();
			macroTree.Refresh();
			m.DisplayTo( actionList );
		}

		public void PlayMacro( Macro m )
		{
			playMacro.Text = "Stop";
			recMacro.Enabled = false;
		}

		public void OnMacroStop()
		{
			recMacro.Text = "Record";
			recMacro.Enabled = true;
			playMacro.Text = "Play";
			playMacro.Enabled = true;
			actionList.SelectedIndex = -1;
			macroTree.Enabled = actionList.Enabled = true;
			newMacro.Enabled = delMacro.Enabled = true;
			RedrawMacros();
		}
		
		private ContextMenu m_MacroContextMenu = null;
		private void macroTree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Right && e.Clicks == 1 )
			{
				if ( m_MacroContextMenu == null )
				{
					m_MacroContextMenu = new ContextMenu( new MenuItem[]
						{
							new MenuItem( "Add Category", new EventHandler( Macro_AddCategory ) ),
							new MenuItem( "Delete Category", new EventHandler( Macro_DeleteCategory ) ),
							new MenuItem( "Move to Category", new EventHandler( Macro_Move2Category ) ),
							new MenuItem( "-" ),
							new MenuItem( "Refresh Macro List", new EventHandler( Macro_RefreshList ) ),
					} );
				}

				Macro sel = GetMacroSel();

				m_MacroContextMenu.MenuItems[1].Enabled = sel == null;
				m_MacroContextMenu.MenuItems[2].Enabled = sel != null;

				m_MacroContextMenu.Show( this, new Point( e.X, e.Y ) );
			}

			//RedrawMacros();
		}

		private TreeNode GetMacroDirNode()
		{
			if ( macroTree.SelectedNode == null )
			{
				return null;
			}
			else
			{
				if ( macroTree.SelectedNode.Tag is string )
					return macroTree.SelectedNode;
				else if ( macroTree.SelectedNode.Parent == null || !(macroTree.SelectedNode.Parent.Tag is string) )
					return null;
				else
					return macroTree.SelectedNode.Parent;
			}
		}

		private void Macro_AddCategory( object sender, EventArgs args )
		{
			if ( !InputBox.Show( this, Language.GetString( LocString.CatName ) ) )
				return;

			string path = InputBox.GetString();
			if ( path == null || path == "" || path.IndexOfAny( Path.GetInvalidPathChars() ) != -1 || path.IndexOfAny( m_InvalidNameChars ) != -1 )
			{
				MessageBox.Show( this, Language.GetString( LocString.InvalidChars ), "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			TreeNode node = GetMacroDirNode();

			try
			{
				if ( node == null || !(node.Tag is string) )
					path = Path.Combine( Config.GetUserDirectory("Macros"), path );
				else
					path = Path.Combine( (string)node.Tag, path );
				Engine.EnsureDirectory( path );
			}
			catch
			{
				MessageBox.Show( this, Language.Format( LocString.CanCreateDir, path ), "Unabled to Create Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			TreeNode newNode = new TreeNode( String.Format( "[{0}]", Path.GetFileName( path ) ) );
			newNode.Tag = path;
			if ( node == null )
				macroTree.Nodes.Add( newNode );
			else
				node.Nodes.Add( newNode );
			RedrawMacros();
			macroTree.SelectedNode = newNode;
		}

		private void Macro_DeleteCategory( object sender, EventArgs args )
		{
			string path = null;
			if ( macroTree.SelectedNode != null )
				path = macroTree.SelectedNode.Tag as string;
			
			if ( path == null )
				return;

			try
			{
				Directory.Delete( path );
			}
			catch
			{
				MessageBox.Show( this, Language.GetString( LocString.CantDelDir ), "Unabled to Delete Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			TreeNode node = FindNode( macroTree.Nodes, path );
			if ( node != null )
				node.Remove();
		}

		private void Macro_Move2Category( object sender, EventArgs args )
		{
			Macro sel = GetMacroSel();
			if ( sel == null )
				return;

			if ( !InputBox.Show( this, Language.GetString( LocString.CatName ) ) )
				return;

			try
			{
				File.Move( sel.Filename, Path.Combine( Config.GetUserDirectory("Macros"), String.Format( "{0}/{1}", InputBox.GetString(), Path.GetFileName( sel.Filename ) ) ) );
			}
			catch
			{
				MessageBox.Show( this, Language.GetString( LocString.CantMoveMacro ), "Unabled to Move Macro", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}

			RedrawMacros();
			macroTree.SelectedNode = FindNode( macroTree.Nodes, sel );
		}

		private void Macro_RefreshList( object sender, EventArgs args )
		{
			RedrawMacros();
		}

		private static TreeNode FindNode( TreeNodeCollection nodes, object tag )
		{
			for( int i=0;i<nodes.Count;i++ )
			{
				TreeNode node = nodes[i];

				if ( node.Tag == tag )
				{
					return node;
				}
				else if ( node.Nodes.Count > 0 )
				{
					node = FindNode( node.Nodes, tag );
					if ( node != null )
						return node;
				}
			}

			return null;
		}

		private void RedrawMacros()
		{
			Macro ms = GetMacroSel();
			MacroManager.DisplayTo( macroTree );
			if ( ms != null )
				macroTree.SelectedNode = FindNode( macroTree.Nodes, ms );
		}

		private void macroTree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if ( MacroManager.Recording )
				return;

			Macro m = e.Node.Tag as Macro;
			macroActGroup.Visible = m != null;
			MacroManager.Select( m, actionList, playMacro, recMacro, loopMacro );
		}

		private void delMacro_Click(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();
			if ( m == null )
			{
				Macro_DeleteCategory(sender,e);
				return;
			}

			if ( m == MacroManager.Current )
				return;

			if ( m.Actions.Count <= 0 || MessageBox.Show( this, Language.Format( LocString.DelConf, m.ToString() ), "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			{
				try
				{
					File.Delete( m.Filename );
				}
				catch
				{
					return;
				}

				MacroManager.Remove( m );

				TreeNode node = FindNode( macroTree.Nodes, m );
				if ( node != null )
					node.Remove();
			}
		}

		private void actionList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Right && e.Clicks == 1 )
			{
				if ( MacroManager.Playing || MacroManager.Recording || World.Player == null )
					return;

				ContextMenu menu = new ContextMenu();
				menu.MenuItems.Add( Language.GetString( LocString.Reload ), new EventHandler( onMacroReload ) );
				menu.MenuItems.Add( Language.GetString( LocString.Save ), new EventHandler( onMacroSave ) );

				MacroAction a;
				try
				{
					a = actionList.SelectedItem as MacroAction;
				}
				catch
				{
					a = null;
				}

				if ( a != null )
				{
					int pos = actionList.SelectedIndex;

					menu.MenuItems.Add( "-" );
					if ( actionList.Items.Count > 1 )
					{
						menu.MenuItems.Add( Language.GetString( LocString.MoveUp ), new EventHandler( OnMacroActionMoveUp ) );
						if ( pos <= 0 )
							menu.MenuItems[menu.MenuItems.Count-1].Enabled = false;
						menu.MenuItems.Add( Language.GetString( LocString.MoveDown ), new EventHandler( OnMacroActionMoveDown ) );
						if ( pos >= actionList.Items.Count - 1 )
							menu.MenuItems[menu.MenuItems.Count-1].Enabled = false;
						menu.MenuItems.Add( "-" );
					}
					menu.MenuItems.Add( Language.GetString( LocString.RemAct ), new EventHandler( onMacroActionDelete ) );
					menu.MenuItems.Add( "-" );
					menu.MenuItems.Add( Language.GetString( LocString.BeginRec ), new EventHandler( onMacroBegRecHere ) );
					menu.MenuItems.Add( Language.GetString( LocString.PlayFromHere ), new EventHandler( onMacroPlayHere ) );

					MenuItem[] aMenus = a.GetContextMenuItems();
					if ( aMenus != null && aMenus.Length > 0 )
					{
						menu.MenuItems.Add( "-" );
						menu.MenuItems.AddRange( aMenus );
					}
				}
				
				menu.MenuItems.Add( "-" );
				menu.MenuItems.Add( Language.GetString( LocString.Constructs ), new MenuItem[]
					{
						new MenuItem( Language.GetString( LocString.InsWait ), new EventHandler( onMacroInsPause ) ),
						new MenuItem( Language.GetString( LocString.InsLT ), new EventHandler( onMacroInsertSetLT ) ),
						new MenuItem( Language.GetString( LocString.InsComment ), new EventHandler( onMacroInsertComment ) ),
						new MenuItem( "-" ),
						new MenuItem( Language.GetString( LocString.InsIF ), new EventHandler( onMacroInsertIf ) ),
						new MenuItem( Language.GetString( LocString.InsELSE ), new EventHandler( onMacroInsertElse ) ),
						new MenuItem( Language.GetString( LocString.InsENDIF ), new EventHandler( onMacroInsertEndIf ) ),
						new MenuItem( "-" ),
						new MenuItem( Language.GetString( LocString.InsFOR ), new EventHandler( onMacroInsertFor ) ),
						new MenuItem( Language.GetString( LocString.InsENDFOR ), new EventHandler( onMacroInsertEndFor ) ),
				} );

				menu.Show( actionList, new Point( e.X, e.Y ) );
			}
		}

		private void onMacroPlayHere(object sender, EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int sel = actionList.SelectedIndex+1;
			if ( sel < 0 || sel > m.Actions.Count )
				sel = m.Actions.Count;

			MacroManager.PlayAt( m, sel );
			playMacro.Text = "Stop";
			recMacro.Enabled = false;

			OnMacroStart( m );
		}

		private void onMacroInsertComment(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();
			if ( m == null )
				return;
			
			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;
			
			if ( InputBox.Show( Language.GetString( LocString.InsComment ) ) )
			{
				m.Actions.Insert( a+1, new MacroComment( InputBox.GetString() ) );
				RedrawActionList( m );
			}
		}

		private void onMacroInsertIf(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			MacroInsertIf ins = new MacroInsertIf( m, a );
			if ( ins.ShowDialog( this ) == DialogResult.OK )
				RedrawActionList( m );
		}

		private void onMacroInsertElse(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			m.Actions.Insert( a+1, new ElseAction() );
			RedrawActionList( m );
		}

		private void onMacroInsertEndIf(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			m.Actions.Insert( a+1, new EndIfAction() );
			RedrawActionList( m );
		}

		private void onMacroInsertFor(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			if ( InputBox.Show( Language.GetString( LocString.NumIter ) ) )
			{
				m.Actions.Insert( a+1, new ForAction( InputBox.GetInt( 1 ) ) );
				RedrawActionList( m );
			}
		}

		private void onMacroInsertEndFor(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			m.Actions.Insert( a+1, new EndForAction() );
			RedrawActionList( m );
		}

		private void OnMacroActionMoveUp(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int move = actionList.SelectedIndex;
			if ( move > 0 && move < m.Actions.Count )
			{
				MacroAction a = (MacroAction)m.Actions[move-1];
				m.Actions[move-1] = m.Actions[move];
				m.Actions[move] = a;

				RedrawActionList( m );
				actionList.SelectedIndex = move - 1;
			}
		}

		private void OnMacroActionMoveDown(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int move = actionList.SelectedIndex;
			if ( move+1 < m.Actions.Count )
			{
				MacroAction a = (MacroAction)m.Actions[move+1];
				m.Actions[move+1] = m.Actions[move];
				m.Actions[move] = a;

				RedrawActionList( m );
				actionList.SelectedIndex = move + 1;
			}
		}

		private void RedrawActionList( Macro m )
		{
			int sel = actionList.SelectedIndex;
			m.DisplayTo( actionList );
			actionList.SelectedIndex = sel;
		}

		private void actionList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Delete )
				onMacroActionDelete(sender, e);
		}

		private void onMacroActionDelete(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a < 0 || a >= m.Actions.Count )
				return;

			if ( MessageBox.Show( this, Language.Format( LocString.DelConf, m.Actions[a].ToString() ), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			{
				m.Actions.RemoveAt( a );
				actionList.Items.RemoveAt( a );
			}
		}

		private void onMacroBegRecHere(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int sel = actionList.SelectedIndex+1;
			if ( sel < 0 || sel > m.Actions.Count )
				sel = m.Actions.Count;

			MacroManager.RecordAt( m, sel );
			recMacro.Text = "Stop";
			playMacro.Enabled = false;
			OnMacroStart( m );
		}

		private void onMacroInsPause(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			MacroInsertWait ins = new MacroInsertWait( m, a );
			if ( ins.ShowDialog( this ) == DialogResult.OK )
				RedrawActionList( m );
		}

		private void onMacroReload(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			m.Load();
			RedrawActionList( m );
		}

		private void onMacroSave(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			m.Save();
			RedrawActionList( m );
		}

		private void onMacroInsertSetLT( object sender, EventArgs e )
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;

			int a = actionList.SelectedIndex;
			if ( a >= m.Actions.Count ) // -1 is valid, will insert @ top
				return;

			m.Actions.Insert( a+1, new SetLastTargetAction() );
			RedrawActionList( m );
		}

		private void loopMacro_CheckedChanged(object sender, System.EventArgs e)
		{
			Macro m = GetMacroSel();;
			if ( m == null )
				return;
			m.Loop = loopMacro.Checked;
		}

		private void spamFilter_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "FilterSpam", spamFilter.Checked );
		}

		private void jump2SearchEx_Click(object sender, System.EventArgs e)
		{
			tabs.SelectedTab = agentsTab;
			agentList.SelectedItem = SearchExemptionAgent.Instance;
		}

		private void screenAutoCap_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoCap", screenAutoCap.Checked );
		}

		private void setScnPath_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			folder.Description = Language.GetString( LocString.SelSSFolder );
			folder.SelectedPath = Config.GetString( "CapPath" );
			folder.ShowNewFolderButton = true;
			
			if ( folder.ShowDialog( this ) == DialogResult.OK )
			{
				Config.SetProperty( "CapPath", folder.SelectedPath );
				screenPath.Text = folder.SelectedPath;
				
				ReloadScreenShotsList();
			}
		}

		public void ReloadScreenShotsList()
		{
			ScreenCapManager.DisplayTo( screensList );
			if ( screenPrev.Image != null )
			{
				screenPrev.Image.Dispose();
				screenPrev.Image = null;
			}
		}

		private void radioFull_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioFull.Checked )
			{
				radioUO.Checked = false;
				Config.SetProperty( "CapFullScreen", true );
			}
		}

		private void radioUO_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioUO.Checked )
			{
				radioFull.Checked = false;
				Config.SetProperty( "CapFullScreen", false );
			}
		}

		private void screensList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if ( screenPrev.Image != null )
			{
				screenPrev.Image.Dispose();
				screenPrev.Image = null;
			}

			if ( screensList.SelectedIndex == -1 )
				return;

			string file = Path.Combine( Config.GetString( "CapPath" ), screensList.SelectedItem.ToString() );
			if ( !File.Exists( file ) )
			{
				MessageBox.Show( this, Language.Format( LocString.FileNotFoundA1, file ), "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				screensList.Items.RemoveAt( screensList.SelectedIndex );
				screensList.SelectedIndex = -1;
				return;
			}

			using ( Stream reader = new FileStream( file, FileMode.Open, FileAccess.Read ) )
			{
				screenPrev.Image = Image.FromStream( reader );
			}
		}

		private void screensList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ( e.Button == MouseButtons.Right && e.Clicks == 1 )
			{
				ContextMenu menu = new ContextMenu();
				menu.MenuItems.Add( "Delete", new EventHandler( DeleteScreenCap ) );
				if ( screensList.SelectedIndex == -1 )
					menu.MenuItems[menu.MenuItems.Count-1].Enabled = false;
				menu.MenuItems.Add( "Delete ALL", new EventHandler( ClearScreensDirectory ) );
				menu.Show( screensList, new Point( e.X, e.Y ) );
			}
		}

		private void DeleteScreenCap(object sender, System.EventArgs e)
		{
			int sel = screensList.SelectedIndex;
			if ( sel == -1 )
				return;

			string file = Path.Combine( Config.GetString( "CapPath" ), (string)screensList.SelectedItem );
			if ( MessageBox.Show( this, Language.Format( LocString.DelConf, file ), "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
				return;

			screensList.SelectedIndex = -1;
			if ( screenPrev.Image != null )
			{
				screenPrev.Image.Dispose();
				screenPrev.Image = null;
			}

			try
			{
				File.Delete( file );
				screensList.Items.RemoveAt( sel );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( this, ex.Message, "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}
			ReloadScreenShotsList();
		}

		private void ClearScreensDirectory(object sender, System.EventArgs e)
		{
			string dir = Config.GetString( "CapPath" );
			if ( MessageBox.Show( this, Language.Format( LocString.Confirm, dir ), "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
				return;

			string[] files = Directory.GetFiles( dir, "*.jpg" );
			StringBuilder sb = new StringBuilder();
			int failed = 0;
			for (int i=0;i<files.Length;i++)
			{
				try
				{
					File.Delete( files[i] );
				}
				catch
				{
					sb.AppendFormat( "{0}\n", files[i] );
					failed ++;
				}
			}

			if ( failed > 0 )
				MessageBox.Show( this, Language.Format( LocString.FileDelError, failed, failed != 1 ? "s" : "", sb.ToString() ), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			ReloadScreenShotsList();
		}

		private void capNow_Click(object sender, System.EventArgs e)
		{
			ScreenCapManager.CaptureNow();
		}

		private void dispTime_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CapTimeStamp", dispTime.Checked );
		}

		public static void LaunchBrowser( string site )
		{
			try
			{
				System.Diagnostics.Process.Start( site );//"iexplore", site );
			}
			catch
			{
				MessageBox.Show( String.Format( "Unable to open browser to '{0}'", site ), "Error", MessageBoxButtons.OK,  MessageBoxIcon.Warning );
			}
		}

		private void donate_Click(object sender, System.EventArgs e)
		{
			LaunchBrowser( "https://www.paypal.com/xclick/business=zippy%40runuo.com&item_name=Razor&no_shipping=1&no_note=1&tax=0&currency_code=USD" );
		}

		private void undressConflicts_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "UndressConflicts", undressConflicts.Checked );
		}

		private void taskbar_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( taskbar.Checked )
			{
				systray.Checked = false;
				Config.SetProperty( "Systray", false );
				if ( !this.ShowInTaskbar )
					MessageBox.Show( this, Language.GetString( LocString.NextRestart ), "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		private void systray_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( systray.Checked )
			{
				taskbar.Checked = false;
				Config.SetProperty( "Systray", true );
				if ( this.ShowInTaskbar )
					MessageBox.Show( this, Language.GetString( LocString.NextRestart ), "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		public void UpdateTitle()
		{
			string str = Language.GetControlText( this.Name );
			if ( str == null || str == "" )
				str = "Razor v{0}";

			str = String.Format( str, Engine.Version );
			if ( World.Player != null )
				this.Text = String.Format( "{0} - {1} ({2})", str, World.Player.Name, World.ShardName );
			else
				this.Text = str;

			UpdateSystray();
		}

		public void UpdateSystray()
		{
			if ( m_NotifyIcon != null && m_NotifyIcon.Visible )
			{
				if ( World.Player != null )
					m_NotifyIcon.Text = String.Format( "Razor - {0} ({1})", World.Player.Name, World.ShardName );
				else
					m_NotifyIcon.Text = "Razor";
			}
		}

		private void DoShowMe(object sender, System.EventArgs e)
		{
			ShowMe();
		}

		public void ShowMe()
		{
			// Fuck windows, seriously.

			ClientCommunication.BringToFront( this.Handle );
			if ( Config.GetBool( "AlwaysOnTop" ) )
				this.TopMost = true;
			if ( WindowState != FormWindowState.Normal )
				WindowState = FormWindowState.Normal;
		}

		private void HideMe(object sender, System.EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
			this.TopMost = false;
			this.SendToBack();
			this.Hide();
		}

		private void NotifyIcon_DoubleClick(object sender, System.EventArgs e)
		{
			ShowMe();
		}

		private void ToggleVisible(object sender, System.EventArgs e)
		{
			if ( this.Visible )
				HideMe(sender,e);
			else
				ShowMe();
		}

		private void OnClose(object sender, System.EventArgs e)
		{
			m_CanClose = true;
			this.Close();
		}

		private void titlebarImages_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "TitlebarImages", titlebarImages.Checked );
			ClientCommunication.RequestTitlebarUpdate();
		}

		private void highlightSpellReags_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "HighlightReagents", highlightSpellReags.Checked );
			ClientCommunication.RequestTitlebarUpdate();
		}

		private void actionStatusMsg_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ActionStatusMsg", actionStatusMsg.Checked );
		}

		private void autoStackRes_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoStack", autoStackRes.Checked );
			//setAutoStackDest.Enabled = autoStackRes.Checked;
		}

		private void screenPath_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "CapPath", screenPath.Text );
		}

		private void rememberPwds_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( rememberPwds.Checked && !Config.GetBool( "RememberPwds" ) )
			{
				if ( MessageBox.Show( this, Language.GetString( LocString.PWWarn ), "Security Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
				{
					rememberPwds.Checked = false;
					return;
				}
			}
			Config.SetProperty( "RememberPwds", rememberPwds.Checked );
		}

		private void langSel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string lang = langSel.SelectedItem as String;
			if ( lang != null && lang != Language.Current )
			{
				if ( !Language.Load( lang ) )
				{
					MessageBox.Show( this, "Unable to load that language.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					langSel.SelectedItem = Language.Current;
				}
				else
				{
					Config.SetRegString( Microsoft.Win32.Registry.CurrentUser, "DefaultLanguage", Language.Current );
					Language.LoadControlNames( this );
					HotKey.RebuildList( hotkeyTree );
				}
			}
		}

		private void tabs_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			HotKey.KeyDown( e.KeyData );
		}

		private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			HotKey.KeyDown( e.KeyData );
		}

		private void spellUnequip_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "SpellUnequip", spellUnequip.Checked );
		}

		private void rangeCheckLT_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "RangeCheckLT", ltRange.Enabled=rangeCheckLT.Checked );
		}

		private void ltRange_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "LTRange", Utility.ToInt32( ltRange.Text, 11 ) );
		}

		private void excludePouches_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "NoSearchPouches", excludePouches.Checked );
		}

		private void clientPrio_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string str = (string)clientPrio.SelectedItem;
			Config.SetProperty( "ClientPrio", str );
			try
			{
				ClientCommunication.ClientProcess.PriorityClass = (System.Diagnostics.ProcessPriorityClass)Enum.Parse( typeof(System.Diagnostics.ProcessPriorityClass), str, true );
			}
			catch
			{
			}
		}

		private void filterSnoop_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "FilterSnoopMsg", filterSnoop.Checked );
		}

		private void preAOSstatbar_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "OldStatBar", preAOSstatbar.Checked );
			ClientCommunication.RequestStatbarPatch( preAOSstatbar.Checked );
			if ( World.Player != null && !m_Initializing )
				MessageBox.Show( this, "Close and re-open your status bar for the change to take effect.", "Status Window Note", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		private void smartLT_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "SmartLastTarget", smartLT.Checked );
		}

		private void showtargtext_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "LastTargTextFlags", showtargtext.Checked );
		}

		private void smartCPU_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "SmartCPU", smartCPU.Checked );

			//if ( !m_Initializing )
			//	MessageBox.Show( this, Language.GetString( LocString.RestartClient ), "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information );
			ClientCommunication.SetSmartCPU( smartCPU.Checked );
		}

		private void dressItems_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Delete )
			{
				DressList list = (DressList)dressList.SelectedItem;
				if ( list == null )
					return;

				int sel = dressItems.SelectedIndex;
				if ( sel < 0 || sel >= list.Items.Count ) 
					return;

				if ( MessageBox.Show( this, Language.GetString( LocString.DelDressItemQ ), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
				{
					try
					{
						list.Items.RemoveAt( sel );
						dressItems.Items.RemoveAt( sel );
					}
					catch
					{
					}
				}
			}
		}

		private void blockDis_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "BlockDismount", blockDis.Checked );
		}

		private void imgFmt_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if ( imgFmt.SelectedIndex != -1 )
				Config.SetProperty( "ImageFormat", imgFmt.SelectedItem );
			else
				Config.SetProperty( "ImageFormat", "jpg" );
		}

		private void vidRec_Click(object sender, System.EventArgs e)
		{
			if ( !PacketPlayer.Playing )
			{
				if ( PacketPlayer.Recording )
					PacketPlayer.Stop();
				else
					PacketPlayer.Record();
			}
		}

		private void recFolder_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			folder.Description = "Select Recording Folder";//Language.GetString( LocString.SelRecFolder );
			folder.SelectedPath = Config.GetString( "RecFolder" );
			folder.ShowNewFolderButton = true;
			
			if ( folder.ShowDialog( this ) == DialogResult.OK )
			{
				Config.SetProperty( "RecFolder", folder.SelectedPath );
				txtRecFolder.Text = folder.SelectedPath;
			}
		}

		private void vidPlay_Click(object sender, System.EventArgs e)
		{
			if ( !PacketPlayer.Playing )
				PacketPlayer.Play();
			else
				PacketPlayer.Pause();
		}

		private void vidPlayStop_Click(object sender, System.EventArgs e)
		{
			if ( PacketPlayer.Playing )
				PacketPlayer.Stop();
		}

		private void vidOpen_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.AddExtension = false;
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;
			ofd.DefaultExt = "rpv";
			ofd.DereferenceLinks = true;
			ofd.Filter = "Razor PacketVideo (*.rpv)|*.rpv|All Files (*.*)|*.*";
			ofd.FilterIndex = 0;
			ofd.InitialDirectory = Config.GetString( "RecFolder" );
			ofd.Multiselect = false;
			ofd.RestoreDirectory = true;
			ofd.ShowHelp = ofd.ShowReadOnly = false;
			ofd.Title = "Select a Video File...";
			ofd.ValidateNames = true;

			if ( ofd.ShowDialog( this ) == DialogResult.OK )
				PacketPlayer.Open( ofd.FileName );
		}

		private void playPos_Scroll(object sender, System.EventArgs e)
		{
			PacketPlayer.OnScroll();
		}

		private void txtRecFolder_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "RecFolder", txtRecFolder.Text );
		}

		private void vidClose_Click(object sender, System.EventArgs e)
		{
			PacketPlayer.Close();
		}

		private void playSpeed_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			PacketPlayer.SetSpeed( playSpeed.SelectedIndex - 2 );
		}

		private void recAVI_Click(object sender, System.EventArgs e)
		{
			if ( !AVIRec.Recording )
			{
				double res = 1.00;
				switch( Config.GetInt( "AviRes" ) )
				{
					case 1: res = 0.75; break;
					case 2: res = 0.50; break;
					case 3: res = 0.25; break;
				}
				if( AVIRec.Record( Config.GetInt( "AviFPS" ), res ) )
				{
					recAVI.Text = "Stop Rec";
				}
			}
			else
			{
				AVIRec.Stop();
				recAVI.Text = "Record AVI Video";
			}
		}

		private void aviFPS_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				int fps = Convert.ToInt32( aviFPS.Text );
				if ( fps < 5 )
					fps = 5;
				else if ( fps > 30 )
					fps = 30;
				Config.SetProperty( "AviFPS", fps );
			}
			catch
			{
			}
		}

		private void aviRes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AviRes", aviRes.SelectedIndex );
		}

		private void autoFriend_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoFriend", autoFriend.Checked );
		}

		private void alwaysStealth_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AlwaysStealth", alwaysStealth.Checked );
		}

		private void autoOpenDoors_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "AutoOpenDoors", autoOpenDoors.Checked );
		}

		private void msglvl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "MessageLevel", msglvl.SelectedIndex );
		}

		private void screenPrev_Click(object sender, System.EventArgs e)
		{
			string file = screensList.SelectedItem as String;
			if ( file != null )
				System.Diagnostics.Process.Start( Path.Combine( Config.GetString( "CapPath" ), file ) );
		}

		private void flipVidHoriz_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "FlipVidH", flipVidHoriz.Checked );
			AVIRec.UpdateFlip();
		}

		private void flipVidVert_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "FlipVidV", flipVidVert.Checked );
			AVIRec.UpdateFlip();
		}

		private Timer m_ResizeTimer = Timer.DelayedCallback( TimeSpan.FromSeconds( 1.0 ), new TimerCallback( ForceSize ) );

		private static void ForceSize()
		{
			int x, y;

			if ( Config.GetBool( "ForceSizeEnabled" ) )
			{
				x = Config.GetInt( "ForceSizeX" );
				y = Config.GetInt( "ForceSizeY" );

				if ( x > 100 && x < 2000 && y > 100 && y < 2000 )
					ClientCommunication.SetGameSize( x, y );
				else
					MessageBox.Show( Engine.MainWindow, Language.GetString( LocString.ForceSizeBad ), "Bad Size", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			}
		}

		private void gameSize_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ForceSizeEnabled", gameSize.Checked );
			forceSizeX.Enabled = forceSizeY.Enabled = gameSize.Checked;

			if ( gameSize.Checked )
			{
				int x = Utility.ToInt32( forceSizeX.Text, 800 );
				int y = Utility.ToInt32( forceSizeY.Text, 600 );

				if ( x < 100 || y < 100 || x > 2000 || y > 2000 )
					MessageBox.Show( this, Language.GetString( LocString.ForceSizeBad ), "Bad Size", MessageBoxButtons.OK, MessageBoxIcon.Stop );
				else
					ClientCommunication.SetGameSize( x, y );
			}
			else
			{
				ClientCommunication.SetGameSize( 800, 600 );
			}

			if ( !m_Initializing )
				MessageBox.Show( this, Language.GetString( LocString.RelogRequired ), "Relog Required", MessageBoxButtons.OK, MessageBoxIcon.Information );

		}

		private void forceSizeX_TextChanged(object sender, System.EventArgs e)
		{
			int x = Utility.ToInt32( forceSizeX.Text, 600 );
			if ( x >= 100 && x <= 2000 )
				Config.SetProperty( "ForceSizeX", x );

			if ( !m_Initializing )
			{
				if ( x > 100 && x < 2000 )
				{
					m_ResizeTimer.Stop();
					m_ResizeTimer.Start();
				}
			}
		}

		private void forceSizeY_TextChanged(object sender, System.EventArgs e)
		{
			int y = Utility.ToInt32( forceSizeY.Text, 600 );
			if ( y >= 100 && y <= 2000 )
				Config.SetProperty( "ForceSizeY", y );

			if ( !m_Initializing )
			{
				if ( y > 100 && y < 2000 )
				{
					m_ResizeTimer.Stop();
					m_ResizeTimer.Start();
				}
			}
		}

		private void potionEquip_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "PotionEquip", potionEquip.Checked );
		}

		private void blockHealPoison_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "BlockHealPoison", blockHealPoison.Checked );
		}

		private void negotiate_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( !m_Initializing )
			{
				Config.SetProperty( "Negotiate", negotiate.Checked );
				ClientCommunication.SetNegotiate( negotiate.Checked );
			}
		}

		private void wikiLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LaunchBrowser("https://github.com/msturgill/razor/wiki");
		}

		private void homeLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LaunchBrowser("https://github.com/msturgill/razor/wiki");
		}

		private void issuesLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			LaunchBrowser("https://github.com/msturgill/razor/issues");
		}

		private void mleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LaunchBrowser( "http://www.mlewallpapers.com/" );
		}

		private void lockBox_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Language.GetString( LocString.FeatureDisabledText ), Language.GetString( LocString.FeatureDisabled ), MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}

		private ArrayList m_LockBoxes = new ArrayList();

		public void LockControl( Control locked )
		{
			if ( locked != null )
			{
				if ( locked.Parent != null && locked.Parent.Controls != null )
				{
					try
					{
						int y_off = (locked.Size.Height - 16) / 2;
						int x_off = 0;
						System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
						PictureBox newLockBox = new PictureBox();

						if ( locked is TextBox )
							x_off += 5;
						else if ( !(locked is CheckBox || locked is RadioButton) )
							x_off = (locked.Size.Width - 16) / 2;

						newLockBox.Cursor = System.Windows.Forms.Cursors.Help;
						newLockBox.Image = ((System.Drawing.Image)(resources.GetObject("lockBox.Image")));
						newLockBox.Size = new System.Drawing.Size(16, 16);
						newLockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
						newLockBox.Click += new System.EventHandler(this.lockBox_Click);

						newLockBox.TabIndex = locked.TabIndex;
						newLockBox.TabStop = locked.TabStop;
						newLockBox.Location = new System.Drawing.Point( locked.Location.X + x_off, locked.Location.Y + y_off );
						newLockBox.Name = locked.Name + "LockBox";
						newLockBox.Tag = locked;
						newLockBox.Visible = true;

						locked.Parent.Controls.Add ( newLockBox );
						locked.Parent.Controls.SetChildIndex( newLockBox, 0 );
						m_LockBoxes.Add( newLockBox );
					}
					catch
					{
					}
				}

				locked.Enabled = false;
			}
		}

		public void UnlockControl( Control unlock )
		{
			if ( unlock != null )
			{
				for (int i=0;i<m_LockBoxes.Count;i++)
				{
					PictureBox box = m_LockBoxes[i] as PictureBox;
					if ( box == null )
						continue;

					if ( box.Tag == unlock )
					{
						unlock.Enabled = true;
						if ( box.Parent != null && box.Parent.Controls != null )
							box.Parent.Controls.Remove( box );

						m_LockBoxes.RemoveAt( i );
						break;
					}
				}
			}
		}

		public void OnLogout()
		{
			OnMacroStop();

			features.Visible = false;

			for (int i=0;i<m_LockBoxes.Count;i++)
			{
				PictureBox box = m_LockBoxes[i] as PictureBox;
				if ( box == null )
					continue;

				box.Parent.Controls.Remove( box );
				if ( box.Tag is Control )
					((Control)box.Tag).Enabled = true;
			}
			m_LockBoxes.Clear();
		}

		public void UpdateControlLocks()
		{
			for (int i=0;i<m_LockBoxes.Count;i++)
			{
				PictureBox box = m_LockBoxes[i] as PictureBox;
				if ( box == null )
					continue;

				box.Parent.Controls.Remove( box );
				if ( box.Tag is Control )
					((Control)box.Tag).Enabled = true;
			}
			m_LockBoxes.Clear();
				
			if ( !ClientCommunication.AllowBit( FeatureBit.SmartLT ) )
				LockControl( this.smartLT );

			if ( !ClientCommunication.AllowBit( FeatureBit.RangeCheckLT ) )
				LockControl( this.rangeCheckLT );
			
			if ( !ClientCommunication.AllowBit( FeatureBit.AutoOpenDoors ) )
				LockControl( this.autoOpenDoors );
		
			if ( !ClientCommunication.AllowBit( FeatureBit.UnequipBeforeCast ) )
				LockControl( this.spellUnequip );
		
			if ( !ClientCommunication.AllowBit( FeatureBit.AutoPotionEquip ) )
				LockControl( this.potionEquip );

			if ( !ClientCommunication.AllowBit( FeatureBit.BlockHealPoisoned ) )
				LockControl( this.blockHealPoison );

			if ( !ClientCommunication.AllowBit( FeatureBit.LoopingMacros ) )
				LockControl( this.loopMacro );

			if ( !ClientCommunication.AllowBit( FeatureBit.OverheadHealth ) )
			{
				LockControl( this.showHealthOH );
				LockControl( this.healthFmt );
				LockControl( this.chkPartyOverhead );
			}
		}

		public Assistant.MapUO.MapWindow MapWindow;

		[System.Runtime.InteropServices.DllImport( "user32.dll" )]
		private static extern IntPtr SetParent( IntPtr child, IntPtr newParent );

		private void btnMap_Click(object sender, System.EventArgs e)
		{
			if ( World.Player != null )
			{
				if ( MapWindow == null )
					MapWindow = new Assistant.MapUO.MapWindow();
				//SetParent( MapWindow.Handle, ClientCommunication.FindUOWindow() );
				//MapWindow.Owner = (Form)Form.FromHandle( ClientCommunication.FindUOWindow() );
				MapWindow.Show();
				MapWindow.BringToFront();
			}
		}

		private void showHealthOH_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ShowHealth", healthFmt.Enabled=showHealthOH.Checked );
		}

		private void healthFmt_TextChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "HealthFmt", healthFmt.Text );
		}

		private void chkPartyOverhead_CheckedChanged(object sender, System.EventArgs e)
		{
			Config.SetProperty( "ShowPartyStats", chkPartyOverhead.Checked );
		}

		private void btcLabel_Click(object sender, EventArgs e)
		{

		}

        private void exportProfile_Click(object sender, EventArgs e)
        {
           MessageBox.Show("TODO!", "TODO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void importProfile_Click(object sender, EventArgs e)
        {
           MessageBox.Show("TODO!", "TODO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void dressTab_Click(object sender, EventArgs e)
        {

        }

        private void exportMacro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO!", "TODO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void macroImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO!", "TODO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void adveditorMacro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO!", "TODO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
	}
}
