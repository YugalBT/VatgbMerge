﻿namespace Standing_Order_Vat_App.MvcHelper
{
    public class PaginationView
    {
        public static string Set_Paging(Int32 PageNumber, int PageSize, Int64 TotalRecords, string ClassName, string PageUrl, string DisableClassName, int branch, int report, DateTime fdate, DateTime tdate, string search)
        {
            string ReturnValue = "";
            try
            {
                if (TotalRecords <= 10)
                {

                }
                else
                {
                    Int64 TotalPages = Convert.ToInt64(Math.Ceiling((double)TotalRecords / PageSize));
                    if (PageNumber > 1)
                    {
                        if (PageNumber == 2)
                            ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href='" + PageUrl.Trim() + "?pn=" + Convert.ToString(PageNumber - 1) + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + " & search = " + search + "  ' class='page-link " + ClassName + "'>Previous</a></li>";
                        else
                        {
                            ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href='" + PageUrl.Trim();
                            if (PageUrl.Contains("?"))
                                ReturnValue = ReturnValue + "&";
                            else
                                ReturnValue = ReturnValue + "?";
                            ReturnValue = ReturnValue + "pn=" + Convert.ToString(PageNumber - 1) + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + "' class='page-link " + ClassName + "'>Previous</a></li>";
                        }
                    }
                    else
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">Previous</a></li>";
                    if ((PageNumber - 3) > 1 && (PageNumber) < 5)
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + ClassName + "' href='" + PageUrl.Trim() + "?pn=" + Convert.ToString(2 - 1) + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + " ' class='page-link " + ClassName + "' >1</a></li>";
                    for (int i = PageNumber - 3; i <= PageNumber; i++)
                        if (i >= 1)
                        {
                            if (PageNumber != i)
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a  href='" + PageUrl.Trim();
                                if (PageUrl.Contains("?"))
                                    ReturnValue = ReturnValue + "&";
                                else
                                    ReturnValue = ReturnValue + "?";
                                ReturnValue = ReturnValue + "pn=" + i.ToString() + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + i.ToString() + "</a></li>";
                            }
                            else
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item " + ClassName + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">" + i + "</a></li>"; ;
                            }
                        }
                    for (int i = PageNumber + 1; i <= PageNumber + 3; i++)
                        if (i <= TotalPages)
                        {
                            if (PageNumber != i)
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a  href='" + PageUrl.Trim();
                                if (PageUrl.Contains("?"))
                                    ReturnValue = ReturnValue + "&";
                                else
                                    ReturnValue = ReturnValue + "?";
                                ReturnValue = ReturnValue + "pn=" + i.ToString() + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + i.ToString() + "</a></li>";
                            }
                            else
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item " + ClassName + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">" + i + "</a></li>"; ;
                            }
                        }
                    if ((PageNumber + 3) < TotalPages)
                    {
                        ReturnValue = ReturnValue + ".....&nbsp; <li class='" + "page-item" + "'><a href = '" + PageUrl.Trim();
                        if (PageUrl.Contains("?"))
                            ReturnValue = ReturnValue + "&";
                        else
                            ReturnValue = ReturnValue + "?";
                        ReturnValue = ReturnValue + "pn=" + TotalPages.ToString() + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + TotalPages.ToString() + "</a></li>";
                    }
                    if (PageNumber < TotalPages)
                    {
                        ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href = '" + PageUrl.Trim();
                        if (PageUrl.Contains("?"))
                            ReturnValue = ReturnValue + "&";
                        else
                            ReturnValue = ReturnValue + "?";
                        ReturnValue = ReturnValue + "pn=" + Convert.ToString(PageNumber + 1) + "&branche=" + branch + "&report=" + report + "&fdate=" + fdate + "&tdate=" + tdate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>Next</a></li>";
                    }
                    else
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">Next</a></li>"; ;
                }

            }
            catch (Exception ex)
            {
            }
            return (ReturnValue);
        }



        public static string Set_Paging_Customer(Int32 PageNumber, int PageSize, Int64 TotalRecords, string ClassName, string PageUrl, string DisableClassName, int acct, int report, DateTime Startdate, DateTime Enddate, string search)
        {
            string ReturnValue = "";
            try
            {
                if (TotalRecords <= 10)
                {

                }
                else
                {
                    Int64 TotalPages = Convert.ToInt64(Math.Ceiling((double)TotalRecords / PageSize));
                    if (PageNumber > 1)
                    {
                        if (PageNumber == 2)
                            ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href='" + PageUrl.Trim() + "?pn=" + Convert.ToString(PageNumber - 1) + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + " & search = " + search + "  ' class='page-link " + ClassName + "'>Previous</a></li>";
                        else
                        {
                            ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href='" + PageUrl.Trim();
                            if (PageUrl.Contains("?"))
                                ReturnValue = ReturnValue + "&";
                            else
                                ReturnValue = ReturnValue + "?";
                            ReturnValue = ReturnValue + "pn=" + Convert.ToString(PageNumber - 1) + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + "' class='page-link " + ClassName + "'>Previous</a></li>";
                        }
                    }
                    else
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">Previous</a></li>";
                    if ((PageNumber - 3) > 1 && (PageNumber) < 5)
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + ClassName + "' href='" + PageUrl.Trim() + "?pn=" + Convert.ToString(2 - 1) + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + " ' class='page-link " + ClassName + "' >1</a></li>";
                    for (int i = PageNumber - 3; i <= PageNumber; i++)
                        if (i >= 1)
                        {
                            if (PageNumber != i)
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a  href='" + PageUrl.Trim();
                                if (PageUrl.Contains("?"))
                                    ReturnValue = ReturnValue + "&";
                                else
                                    ReturnValue = ReturnValue + "?";
                                ReturnValue = ReturnValue + "pn=" + i.ToString() + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + i.ToString() + "</a></li>";
                            }
                            else
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item " + ClassName + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">" + i + "</a></li>"; ;
                            }
                        }
                    for (int i = PageNumber + 1; i <= PageNumber + 3; i++)
                        if (i <= TotalPages)
                        {
                            if (PageNumber != i)
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a  href='" + PageUrl.Trim();
                                if (PageUrl.Contains("?"))
                                    ReturnValue = ReturnValue + "&";
                                else
                                    ReturnValue = ReturnValue + "?";
                                ReturnValue = ReturnValue + "pn=" + i.ToString() + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + i.ToString() + "</a></li>";
                            }
                            else
                            {
                                ReturnValue = ReturnValue + "<li class='" + "page-item " + ClassName + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">" + i + "</a></li>"; ;
                            }
                        }
                    if ((PageNumber + 3) < TotalPages)
                    {
                        ReturnValue = ReturnValue + ".....&nbsp; <li class='" + "page-item" + "'><a href = '" + PageUrl.Trim();
                        if (PageUrl.Contains("?"))
                            ReturnValue = ReturnValue + "&";
                        else
                            ReturnValue = ReturnValue + "?";
                        ReturnValue = ReturnValue + "pn=" + TotalPages.ToString() + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>" + TotalPages.ToString() + "</a></li>";
                    }
                    if (PageNumber < TotalPages)
                    {
                        ReturnValue = ReturnValue + "<li class='" + "page-item" + "'><a href = '" + PageUrl.Trim();
                        if (PageUrl.Contains("?"))
                            ReturnValue = ReturnValue + "&";
                        else
                            ReturnValue = ReturnValue + "?";
                        ReturnValue = ReturnValue + "pn=" + Convert.ToString(PageNumber + 1) + "&acct=" + acct + "&report=" + report + "&Startdate=" + Startdate + "&Enddate=" + Enddate + "&search=" + search + "' class='" + "page-link " + ClassName + "'>Next</a></li>";
                    }
                    else
                        ReturnValue = ReturnValue + "<li class='" + "page-item " + "'><a class='" + "page-link " + DisableClassName + "' href=" + "#" + ">Next</a></li>"; ;
                }

            }
            catch (Exception ex)
            {
            }
            return (ReturnValue);
        }

    }
}
