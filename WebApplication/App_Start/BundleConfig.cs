using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);

            RegisterShared(bundles);

            RegisterAccount(bundles);

            RegisterHome(bundles);

            RegisterCharts(bundles);

            RegisterWidgets(bundles);

            RegisterElements(bundles);

            RegisterForms(bundles);

            RegisterTables(bundles);

            RegisterCalendar(bundles);

            RegisterMailbox(bundles);

            RegisterExamples(bundles);

            RegisterDocumentation(bundles);
        }

        private static void RegisterDocumentation(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Documentation").Include(
                "~/Scripts/Documentation/Documentation.js"));
        }

        private static void RegisterExamples(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Examples/Blank").Include(
                "~/Scripts/Examples/Blank.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/Invoice").Include(
                "~/Scripts/Examples/Invoice.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/Lockscreen").Include(
                "~/Scripts/Examples/Lockscreen.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/Login").Include(
                "~/Scripts/Examples/Login.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/P404").Include(
                "~/Scripts/Examples/P404.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/P500").Include(
                "~/Scripts/Examples/P500.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/Pace").Include(
                "~/Scripts/Examples/Pace.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/ProfileEx").Include(
                "~/Scripts/Examples/ProfileEx.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Examples/Register").Include(
                "~/Scripts/Examples/Register.js"));
        }

        private static void RegisterMailbox(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Mailbox").Include(
                "~/Scripts/Mailbox/Inbox.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Mailbox").Include(
                "~/Scripts/Mailbox/Compose.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Mailbox").Include(
                "~/Scripts/Mailbox/Read.js"));
        }

        private static void RegisterCalendar(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Calendar").Include(
                "~/Scripts/Calendar/Calendar.js"));
        }

        private static void RegisterTables(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Tables/Simple").Include(
                "~/Scripts/Tables/Simple.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Tables/Data").Include(
                "~/Scripts/Tables/Data.js"));
        }

        private static void RegisterForms(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Forms/Advanced").Include(
                "~/Scripts/Forms/Advanced.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Forms/Editors").Include(
                "~/Scripts/Forms/Editors.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Forms/General").Include(
                "~/Scripts/Forms/General.js"));
        }

        private static void RegisterElements(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Elements/Buttons").Include(
                "~/Scripts/Elements/Buttons.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Elements/General").Include(
                "~/Scripts/Elements/General.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/General").Include(
                "~/Styles/Elements/General.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Elements/Icons").Include(
                "~/Scripts/Elements/Icons.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/Icons").Include(
                "~/Styles/Elements/Icons.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Elements/Modals").Include(
                "~/Scripts/Elements/Modals.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/Modals").Include(
                "~/Styles/Elements/Modals.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Elements/Sliders").Include(
                "~/Scripts/Elements/Sliders.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Elements/Timeline").Include(
                "~/Scripts/Elements/Timeline.js"));
        }

        private static void RegisterWidgets(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Widgets").Include(
                "~/Scripts/Widgets/Widgets.js"));
        }

        private static void RegisterCharts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Charts/ChartsJs").Include(
                "~/Scripts/Charts/ChartsJs.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Charts/Morris").Include(
                "~/Scripts/Charts/Morris.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Charts/Flot").Include(
                "~/Scripts/Charts/Flot.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Charts/Inline").Include(
                "~/Scripts/Charts/Inline.js"));
        }

        private static void RegisterHome(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Home/DashboardV1").Include(
                "~/Scripts/Home/DashboardV1.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Home/DashboardV2").Include(
                "~/Scripts/Home/DashboardV2.js"));
        }

        private static void RegisterAccount(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Account/Login").Include(
                "~/Scripts/Account/Login.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Account/Register").Include(
                "~/Scripts/Account/Register.js"));
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Shared/_Layout").Include(
                "~/Scripts/Shared/_Layout.js"));
        }

        private static void RegisterLayout(BundleCollection bundles)
        {
            // bootstrap
            bundles.Add(new ScriptBundle("~/AdminLTE/bootstrap/js").Include(
                "~/AdminLTE/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/bootstrap/css").Include(
                "~/AdminLTE/bootstrap/css/bootstrap.min.css"));
            
            // dist
            bundles.Add(new ScriptBundle("~/AdminLTE/dist/js").Include(
                "~/AdminLTE/dist/js/app.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/css").Include(
                "~/AdminLTE/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/css/skins").Include(
                "~/AdminLTE/dist/css/skins/_all-skins.min.css"));

            // documentation
            bundles.Add(new ScriptBundle("~/AdminLTE/documentation/js").Include(
                "~/AdminLTE/documentation/js/docs.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/documentation/css").Include(
                "~/AdminLTE/documentation/css/style.css"));

            // plugins | bootstrap-slider
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/bootstrap-slider/js").Include(
                                        "~/AdminLTE/plugins/bootstrap-slider/js/bootstrap-slider.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-slider/css").Include(
                                        "~/AdminLTE/plugins/bootstrap-slider/css/slider.css"));

            // plugins | bootstrap-wysihtml5
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/bootstrap-wysihtml5/js").Include(
                                         "~/AdminLTE/plugins/bootstrap-wysihtml5/js/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-wysihtml5/css").Include(
                                        "~/AdminLTE/plugins/bootstrap-wysihtml5/css/bootstrap3-wysihtml5.min.css"));

            // plugins | chartjs
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/chartjs/js").Include(
                                         "~/AdminLTE/plugins/chartjs/js/chart.min.js"));

            // plugins | ckeditor
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/ckeditor/js").Include(
                                         "~/AdminLTE/plugins/ckeditor/js/ckeditor.js"));

            // plugins | colorpicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/colorpicker/js").Include(
                                         "~/AdminLTE/plugins/colorpicker/js/bootstrap-colorpicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/colorpicker/css").Include(
                                        "~/AdminLTE/plugins/colorpicker/css/bootstrap-colorpicker.css"));

            // plugins | datatables
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/datatables/js").Include(
                                         "~/AdminLTE/plugins/datatables/js/jquery.dataTables.min.js",
                                         "~/AdminLTE/plugins/datatables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datatables/css").Include(
                                        "~/AdminLTE/plugins/datatables/css/dataTables.bootstrap.css"));

            // plugins | datepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/datepicker/js").Include(
                                         "~/AdminLTE/plugins/datepicker/js/bootstrap-datepicker.js",
                                         "~/AdminLTE/plugins/datepicker/js/locales/bootstrap-datepicker*"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datepicker/css").Include(
                                        "~/AdminLTE/plugins/datepicker/css/datepicker3.css"));

            // plugins | daterangepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/daterangepicker/js").Include(
                                         "~/AdminLTE/plugins/daterangepicker/js/moment.min.js",
                                         "~/AdminLTE/plugins/daterangepicker/js/daterangepicker.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/daterangepicker/css").Include(
                                        "~/AdminLTE/plugins/daterangepicker/css/daterangepicker-bs3.css"));

            // plugins | fastclick
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/fastclick/js").Include(
                                         "~/AdminLTE/plugins/fastclick/js/fastclick.min.js"));

            // plugins | flot
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/flot/js").Include(
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.resize.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.pie.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.categories.min.js"));

            // plugins | font-awesome
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/font-awesome/css").Include(
                                        "~/AdminLTE/plugins/font-awesome/css/font-awesome.min.css"));

            // plugins | fullcalendar
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/fullcalendar/js").Include(
                                         "~/AdminLTE/plugins/fullcalendar/js/fullcalendar.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/css").Include(
                                        "~/AdminLTE/plugins/fullcalendar/css/fullcalendar.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/css/print").Include(
                                        "~/AdminLTE/plugins/fullcalendar/css/print/fullcalendar.print.css"));

            // plugins | icheck
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/icheck/js").Include(
                                         "~/AdminLTE/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css").Include(
                                        "~/AdminLTE/plugins/icheck/css/all.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/flat").Include(
                                        "~/AdminLTE/plugins/icheck/css/flat/flat.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/sqare/blue").Include(
                                        "~/AdminLTE/plugins/icheck/css/sqare/blue.css"));

            // plugins | input-mask
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/input-mask/js").Include(
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.js",
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.date.extensions.js",
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.extensions.js"));

            // plugins | ionicons
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionicons/css").Include(
                                        "~/AdminLTE/plugins/ionicons/css/ionicons.min.css"));

            // plugins | ionslider
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/ionslider/js").Include(
                                         "~/AdminLTE/plugins/ionslider/js/ion.rangeSlider.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionslider/css").Include(
                                        "~/AdminLTE/plugins/ionslider/css/ion.rangeSlider.css",
                                        "~/AdminLTE/plugins/ionslider/css/ion.rangeSlider.skinNice.css"));

            // plugins | jquery
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery/js").Include(
                                         "~/AdminLTE/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | jquery-validate
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery-validate/js").Include(
                                         "~/AdminLTE/plugins/jquery-validate/js/jquery.validate*"));

            // plugins | jquery-ui
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery-ui/js").Include(
                                         "~/AdminLTE/plugins/jquery-ui/js/jquery-ui.min.js"));

            // plugins | jvectormap
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jvectormap/js").Include(
                                         "~/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js",
                                         "~/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/jvectormap/css").Include(
                                        "~/AdminLTE/plugins/jvectormap/css/jquery-jvectormap-1.2.2.css"));

            // plugins | knob
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/knob/js").Include(
                                         "~/AdminLTE/plugins/knob/js/jquery.knob.js"));

            // plugins | morris
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/morris/css").Include(
                                        "~/AdminLTE/plugins/morris/css/morris.css"));

            // plugins | momentjs
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/momentjs/js").Include(
                                         "~/AdminLTE/plugins/momentjs/js/moment.min.js"));

            // plugins | pace
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/pace/js").Include(
                                         "~/AdminLTE/plugins/pace/js/pace.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/pace/css").Include(
                                        "~/AdminLTE/plugins/pace/css/pace.min.css"));

            // plugins | slimscroll
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/slimscroll/js").Include(
                                         "~/AdminLTE/plugins/slimscroll/js/jquery.slimscroll.min.js"));

            // plugins | sparkline
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/sparkline/js").Include(
                                         "~/AdminLTE/plugins/sparkline/js/jquery.sparkline.min.js"));

            // plugins | timepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/timepicker/js").Include(
                                         "~/AdminLTE/plugins/timepicker/js/bootstrap-timepicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/timepicker/css").Include(
                                        "~/AdminLTE/plugins/timepicker/css/bootstrap-timepicker.min.css"));

            // plugins | raphael
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/raphael/js").Include(
                                         "~/AdminLTE/plugins/raphael/js/raphael-min.js"));

            // plugins | select2
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/select2/js").Include(
                                         "~/AdminLTE/plugins/select2/js/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/select2/css").Include(
                                        "~/AdminLTE/plugins/select2/css/select2.min.css"));

            // plugins | morris
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/morris/js").Include(
                                         "~/AdminLTE/plugins/morris/js/morris.min.js"));

        }
    }
}
