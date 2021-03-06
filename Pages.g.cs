//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject32
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Silverlight;
    using ArtOfTest.WebAii.Wpf;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : C:\Users\kotsev\AppData\LocalLow\Microsoft\Silverlight\OutOfBrowser\1864436354.www.microsoft.com\index.html 
        /// </summary>
        public MicrosoftSilverlightPage MicrosoftSilverlight
        {
            get
            {
                return new MicrosoftSilverlightPage("C:\\Users\\kotsev\\AppData\\LocalLow\\Microsoft\\Silverlight\\OutOfBrowser\\1864436354.ww" +
                        "w.microsoft.com\\index.html", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.w3schools.com/tags/tryit.asp?filename=tryhtml_button_test 
        /// </summary>
        public TryitEditorV28Page TryitEditorV28
        {
            get
            {
                return new TryitEditorV28Page("http://www.w3schools.com/tags/tryit.asp?filename=tryhtml_button_test", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://www.google.bg/?gfe_rd=cr&ei=yLsxV_OVDsWz8weH9Kxo&gws_rd=ssl 
        /// </summary>
        public GooglePage Google
        {
            get
            {
                return new GooglePage("https://www.google.bg/?gfe_rd=cr&ei=yLsxV_OVDsWz8weH9Kxo&gws_rd=ssl", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://www.google.bg/?gfe_rd=cr&ei=M9AxV9qeB8Wz8weH9Kxo&gws_rd=ssl 
        /// </summary>
        public Google0Page Google0
        {
            get
            {
                return new Google0Page("https://www.google.bg/?gfe_rd=cr&ei=M9AxV9qeB8Wz8weH9Kxo&gws_rd=ssl", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://www.google.bg/?gfe_rd=cr&ei=M9AxV9qeB8Wz8weH9Kxo&gws_rd=ssl#q=%D1%82%D0%B5%D0%BB%D0%B5%D1%80%D0%B8%D0%BA 
        /// </summary>
        public ТелерикGoogleТърсенеPage ТелерикGoogleТърсене
        {
            get
            {
                return new ТелерикGoogleТърсенеPage("https://www.google.bg/?gfe_rd=cr&ei=M9AxV9qeB8Wz8weH9Kxo&gws_rd=ssl#q=%D1%82%D0%B" +
                        "5%D0%BB%D0%B5%D1%80%D0%B8%D0%BA", _manager.ActiveBrowser.Find);
            }
        }
        public class MicrosoftSilverlightPage : HtmlPage
        {
            public MicrosoftSilverlightPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
            ///
            /// </summary>
            public SilverlightAppElement SilverlightApp
            {
                get
                {
                    ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl plugin = Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=object", "type=~application/x-silverlight");
                    int appIndex = plugin.OwnerBrowser.GetSilverlightAppIndex(plugin);
                    return new SilverlightAppElement(plugin.OwnerBrowser.SilverlightApps()[appIndex].Find);
                }
            }
            public class SilverlightAppElement : XamlElementContainer
            {
                public SilverlightAppElement(VisualFind find) : 
                        base(find)
                {
                }
                /// <summary>
                /// Find expressions for this page
                /// </summary>
                public ExpressionDefinitions Expressions
                {
                    get
                    {
                        return new ExpressionDefinitions();
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
                /// (Silverlight): [AutomationId 'Exact' ContactListBox] AND [XamlTag 'Exact' listbox]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.UI.ListBox ContactListBoxListbox
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.UI.ListBox>("AutomationId=ContactListBox", "XamlTag=listbox");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
                /// (Silverlight): [name 'Exact' EditorForm] AND [XamlTag 'Exact' contactform][XamlPath 'Exact' /grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox[0]/grid[name=RootElement]/border[name=Border]/grid[0]/border[name=MouseOverBorder]/scrollviewer[automationid=ContentElement]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/textboxview[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.FrameworkElement Item0Textboxview
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.FrameworkElement>("XamlTag=contactform", "name=EditorForm", "|", @"XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox[0]/grid[name=RootElement]/border[name=Border]/grid[0]/border[name=MouseOverBorder]/scrollviewer[automationid=ContentElement]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/textboxview[0]");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
                /// (Silverlight): [name 'Exact' EditorForm] AND [XamlTag 'Exact' contactform][XamlPath 'Exact' /grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.UI.Grid FirstGrid
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.UI.Grid>("XamlTag=contactform", "name=EditorForm", "|", "XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/gri" +
                                "d[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
                /// (Silverlight): [name 'Exact' EditorForm] AND [XamlTag 'Exact' contactform][XamlPath 'Exact' /grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.UI.TextBox Item0Textbox
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.UI.TextBox>("XamlTag=contactform", "name=EditorForm", "|", "XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/gri" +
                                "d[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox" +
                                "[0]");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' object] AND [type 'Contains' application/x-silverlight]
                /// (Silverlight): [TextContent 'Exact' CANCEL] AND [XamlTag 'Exact' textblock]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.UI.TextBlock CANCELTextblock
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.UI.TextBlock>("TextContent=CANCEL", "XamlTag=textblock");
                    }
                }
                public class ExpressionDefinitions
                {
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression ContactListBoxListbox = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("AutomationId=ContactListBox", "XamlTag=listbox");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression Item0Textboxview = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlTag=contactform", "name=EditorForm", "|", @"XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox[0]/grid[name=RootElement]/border[name=Border]/grid[0]/border[name=MouseOverBorder]/scrollviewer[automationid=ContentElement]/border[0]/grid[0]/scrollcontentpresenter[name=ScrollContentPresenter]/textboxview[0]");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression FirstGrid = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlTag=contactform", "name=EditorForm", "|", "XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/gri" +
                            "d[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression Item0Textbox = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlTag=contactform", "name=EditorForm", "|", "XamlPath=/grid[0]/border[0]/scrollviewer[automationid=ScrollViewer]/border[0]/gri" +
                            "d[0]/scrollcontentpresenter[name=ScrollContentPresenter]/grid[0]/grid[0]/textbox" +
                            "[0]");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression CANCELTextblock = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("TextContent=CANCEL", "XamlTag=textblock");
                }
            }
        }
        public class TryitEditorV28Page : HtmlPage
        {
            private Browser _ownerBrowser;
            public TryitEditorV28Page(string url, Find find) : 
                    base(url, find)
            {
                this._ownerBrowser = find.AssociatedBrowser;
            }
            /// <summary>
            /// [Frame:id=iframeResult,name=Frame_1,UseQuery:False]
            /// </summary>
            public FrameIframeResultFrame FrameIframeResult
            {
                get
                {
                    FrameInfo frameInfo = new FrameInfo("iframeResult", "Frame_1", "", "", 1, false, false, "");
                    this._ownerBrowser.WaitForFrame(frameInfo);
                    return new FrameIframeResultFrame(this._ownerBrowser.Frames[frameInfo].Find);
                }
            }
            public class FrameIframeResultFrame : HtmlElementContainer
            {
                public FrameIframeResultFrame(Find find) : 
                        base(find)
                {
                }
                /// <summary>
                /// Find expressions for this page
                /// </summary>
                public ExpressionDefinitions Expressions
                {
                    get
                    {
                        return new ExpressionDefinitions();
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Click Me!]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton ClickMeButtonTag
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("TextContent=Click Me!", "tagname=button");
                    }
                }
                public class ExpressionDefinitions
                {
                    public ArtOfTest.WebAii.Core.HtmlFindExpression ClickMeButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Click Me!", "tagname=button");
                }
            }
        }
        public class GooglePage : HtmlPage
        {
            public GooglePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' hplogo] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv HplogoDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=hplogo", "tagname=div");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression HplogoDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=hplogo", "tagname=div");
            }
        }
        public class Google0Page : HtmlPage
        {
            public Google0Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' lst-ib] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText LstIbText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=lst-ib", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LstIbText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=lst-ib", "tagname=input");
            }
        }
        public class ТелерикGoogleТърсенеPage : HtmlPage
        {
            public ТелерикGoogleТърсенеPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' btnG][tagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("name=btnG", "|", "tagIndex=span:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("name=btnG", "|", "tagIndex=span:0");
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Application Path : C:\Users\kotsev\Documents\Visual Studio 2012\Projects\WpfApplication1\WpfApplication1\bin\Debug\WpfApplication1.exe 
        /// </summary>
        public WpfApplication1exeApplication WpfApplication1exe
        {
            get
            {
                return new WpfApplication1exeApplication(_manager.ActiveApplication);
            }
        }
        public class WpfApplication1exeApplication : XamlApplication
        {
            public WpfApplication1exeApplication(WpfApplication application) : 
                    base(application)
            {
            }
            /// <summary>
            /// Window Title : MainWindow 
            /// </summary>
            public MainWindowWindow MainWindow
            {
                get
                {
                    return new MainWindowWindow(this.OwnerApplication.WaitForWindow("MainWindow").Find);
                }
            }
            public class MainWindowWindow : XamlElementContainer
            {
                public MainWindowWindow(VisualFind find) : 
                        base(find)
                {
                }
                /// <summary>
                /// Find expressions for this page
                /// </summary>
                public ExpressionDefinitions Expressions
                {
                    get
                    {
                        return new ExpressionDefinitions();
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Wpf): [TextContent 'Exact' Button] AND [XamlTag 'Exact' textblock]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Controls.Xaml.Wpf.TextBlock ButtonTextblock
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Controls.Xaml.Wpf.TextBlock>("TextContent=Button", "XamlTag=textblock");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Wpf): [name 'Exact' PART_ContentHost] AND [XamlTag 'Exact' scrollviewer][XamlPath 'Exact' /grid[0]/scrollcontentpresenter[0]/textboxview[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Silverlight.FrameworkElement Item0Textboxview
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Silverlight.FrameworkElement>("XamlTag=scrollviewer", "name=PART_ContentHost", "|", "XamlPath=/grid[0]/scrollcontentpresenter[0]/textboxview[0]");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Wpf): [XamlPath 'Exact' /border[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Controls.Xaml.Wpf.Border ButtonBorder
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Controls.Xaml.Wpf.Border>("XamlPath=/border[0]");
                    }
                }
                /// <summary>
                /// Find logic 
                /// (Wpf): [XamlPath 'Exact' /border[0]/adornerdecorator[0]/contentpresenter[0]/grid[0]/textbox[0]]
                ///
                /// </summary>
                public ArtOfTest.WebAii.Controls.Xaml.Wpf.TextBox Item0Textbox
                {
                    get
                    {
                        return Get<ArtOfTest.WebAii.Controls.Xaml.Wpf.TextBox>("XamlPath=/border[0]/adornerdecorator[0]/contentpresenter[0]/grid[0]/textbox[0]");
                    }
                }
                public class ExpressionDefinitions
                {
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression ButtonTextblock = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("TextContent=Button", "XamlTag=textblock");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression Item0Textboxview = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlTag=scrollviewer", "name=PART_ContentHost", "|", "XamlPath=/grid[0]/scrollcontentpresenter[0]/textboxview[0]");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression ButtonBorder = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlPath=/border[0]");
                    public ArtOfTest.WebAii.Silverlight.XamlFindExpression Item0Textbox = new ArtOfTest.WebAii.Silverlight.XamlFindExpression("XamlPath=/border[0]/adornerdecorator[0]/contentpresenter[0]/grid[0]/textbox[0]");
                }
            }
        }
    }
}
