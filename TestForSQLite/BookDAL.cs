using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;


namespace TestForSQLite
{
    class BookDAL
    {



        public static void CreateStaticData(StaticData[] staticDataArry, MainWindow mw, int size)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection("Data Source=G:/Documents/GitHub/TestForSQLite/Data.sqlite;");

                conn.Open();
                using (DbTransaction dbTrans = conn.BeginTransaction())
                {
                    using (DbCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                                for (int i = 0; i < size; i++)
                                {

                                    cmd.CommandText = "INSERT INTO StaticData(InstrumentID, InstrumentName, ExchangeID, ExchangeName,ExchangeInstID,Type,ExercisePrice,DueDate,CallOrPut,OptionOrFuture)"
                                    +"VALUES(@InstrumentID1, @InstrumentName1, @ExchangeID1, @ExchangeName1,@ExchangeInstID1,@Type1,@ExercisePrice1,@DueDate1,@CallOrPut1,@OptionOrFuture1)";
                                    
                                    cmd.Parameters.Add(new SQLiteParameter("InstrumentID1", staticDataArry[i].InstrumentID));
                                    cmd.Parameters.Add(new SQLiteParameter("InstrumentName1", staticDataArry[i].InstrumentName));
                                    cmd.Parameters.Add(new SQLiteParameter("ExchangeID1", staticDataArry[i].ExchangeID));
                                    cmd.Parameters.Add(new SQLiteParameter("ExchangeName1", staticDataArry[i].ExchangeName));
                                    cmd.Parameters.Add(new SQLiteParameter("ExchangeInstID1", staticDataArry[i].ExchangeInstID));
                                    cmd.Parameters.Add(new SQLiteParameter("Type1", staticDataArry[i].Type));
                                    cmd.Parameters.Add(new SQLiteParameter("ExercisePrice1", staticDataArry[i].ExercisePrice));
                                    cmd.Parameters.Add(new SQLiteParameter("DueDate1", staticDataArry[i].DueDate));
                                    cmd.Parameters.Add(new SQLiteParameter("CallOrPut1", staticDataArry[i].CallOrPut));
                                    cmd.Parameters.Add(new SQLiteParameter("OptionOrFuture1", staticDataArry[i].OptionOrFuture));

                                    cmd.ExecuteNonQuery();
                                }
                            dbTrans.Commit();
                            mw.testBox.Text += "StaticData     Succeed   "+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Commit!"+" \n";
                        }
                           
                        catch
                        {
                            dbTrans.Rollback();
                            mw.testBox.Text += "StaticData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Rollback!" + " \n";
                        }
                       
                           
                    }

                }
                //SQLiteCommand cmd = conn.CreateCommand();
                //cmd.CommandText = "INSERT INTO Book(ID, BookName, Price, Rowguid) VALUES(@ID1, @BookName1, @Price1, @Rowguid1)";
                //cmd.Parameters.Add(new SQLiteParameter("ID1", book.ID));
                //cmd.Parameters.Add(new SQLiteParameter("BookName1", book.BookName));
                //cmd.Parameters.Add(new SQLiteParameter("Price1", book.Price));
                //cmd.Parameters.Add(new SQLiteParameter("Rowguid1", book.Rowguid));

                //int i = cmd.ExecuteNonQuery();
                //return i == 1;
            }
            catch (SQLiteException se)
            {

                mw.testBox.Text += "StaticData     Fail  " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data + " \n";
                //return false;
            }
            catch (ArgumentException ae)
            {
                mw.testBox.Text += "StaticData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace + "\n\n" + ae.Data + " \n";
               // return false;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                mw.testBox.Text += "StaticData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ex.Message + "\n\n" + ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.Data + " \n";
               // return false;
            }
        }



        public static void CreateDynamicData(DynamicData[] dynamicDataArry, MainWindow mw, int size)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection("Data Source=G:/Documents/GitHub/TestForSQLite/Data.sqlite;");

                conn.Open();
                using (DbTransaction dbTrans = conn.BeginTransaction())
                {
                    using (DbCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                            
                            for (int i = 0; i < size; i++)
                            {

                                cmd.CommandText = "INSERT INTO DynamicData(InstrumentID,TradingDay,LastPrice,HighestPrice,LowestPrice,Volume,OpenInterest,UpperLimitPrice,LowerLimitPrice,PreClosePrice,PreOpenInterest,OpenPrice,ClosePrice,BidPrice1,BidVolume1,AskPrice1,AskVolume1,AveragePrice,UpdateTime,UpdateMillisec,RiseAndFall,RiseAndFallRate,SettlementPrice,PreSettlementPrice,Turnover)"
                                + " VALUES(@InstrumentID1,@TradingDay1,@LastPrice1,@HighestPrice1,@LowestPrice1,@Volume1,@OpenInterest1,@UpperLimitPrice1,@LowerLimitPrice1,@PreClosePrice1,"
                                +"@PreOpenInterest1,@OpenPrice1,@ClosePrice1,@BidPrice11,@BidVolume11,@AskPrice11,@AskVolume11,@AveragePrice1,@UpdateTime1,@UpdateMillisec1,@RiseAndFall1,@RiseAndFallRate1,@SettlementPrice1,@PreSettlementPrice1,@Turnover1)";

                                //cmd.Parameters.Add(new SQLiteParameter("ID1", 1));
                                
                                cmd.Parameters.Add(new SQLiteParameter("InstrumentID1", dynamicDataArry[i].InstrumentID));
                                cmd.Parameters.Add(new SQLiteParameter("TradingDay1", dynamicDataArry[i].TradingDay));
                                cmd.Parameters.Add(new SQLiteParameter("LastPrice1", dynamicDataArry[i].LastPrice));
                                cmd.Parameters.Add(new SQLiteParameter("HighestPrice1", dynamicDataArry[i].HighestPrice));
                                cmd.Parameters.Add(new SQLiteParameter("LowestPrice1", dynamicDataArry[i].LowestPrice));
                                cmd.Parameters.Add(new SQLiteParameter("Volume1", dynamicDataArry[i].Volume));
                                cmd.Parameters.Add(new SQLiteParameter("OpenInterest1", dynamicDataArry[i].OpenInterest));
                                cmd.Parameters.Add(new SQLiteParameter("UpperLimitPrice1", dynamicDataArry[i].UpperLimitPrice));
                                cmd.Parameters.Add(new SQLiteParameter("LowerLimitPrice1", dynamicDataArry[i].LowerLimitPrice));
                                cmd.Parameters.Add(new SQLiteParameter("PreClosePrice1", dynamicDataArry[i].PreClosePrice));

                                cmd.Parameters.Add(new SQLiteParameter("PreOpenInterest1", dynamicDataArry[i].PreOpenInterest));
                                cmd.Parameters.Add(new SQLiteParameter("OpenPrice1", dynamicDataArry[i].OpenPrice));
                                cmd.Parameters.Add(new SQLiteParameter("ClosePrice1", dynamicDataArry[i].ClosePrice));
                                cmd.Parameters.Add(new SQLiteParameter("BidPrice11", dynamicDataArry[i].BidPrice1));
                                cmd.Parameters.Add(new SQLiteParameter("BidVolume11", dynamicDataArry[i].BidVolume1));
                                cmd.Parameters.Add(new SQLiteParameter("AskPrice11", dynamicDataArry[i].AskPrice1));
                                cmd.Parameters.Add(new SQLiteParameter("AskVolume11", dynamicDataArry[i].AskVolume1));
                                cmd.Parameters.Add(new SQLiteParameter("AveragePrice1", dynamicDataArry[i].AveragePrice));
                                cmd.Parameters.Add(new SQLiteParameter("UpdateTime1", dynamicDataArry[i].UpdateTime));
                                cmd.Parameters.Add(new SQLiteParameter("UpdateMillisec1", dynamicDataArry[i].UpdateMillisec));



                                cmd.Parameters.Add(new SQLiteParameter("RiseAndFall1", dynamicDataArry[i].RiseAndFall));
                                cmd.Parameters.Add(new SQLiteParameter("RiseAndFallRate1", dynamicDataArry[i].RiseAndFallRate));
                                cmd.Parameters.Add(new SQLiteParameter("SettlementPrice1", dynamicDataArry[i].SettlementPrice));
                                cmd.Parameters.Add(new SQLiteParameter("PreSettlementPrice1", dynamicDataArry[i].PreSettlementPrice));
                                cmd.Parameters.Add(new SQLiteParameter("Turnover1", dynamicDataArry[i].Turnover));
                                

                              

                                cmd.ExecuteNonQuery();
                            }
                            
                            
                            dbTrans.Commit();
                            mw.testBox.Text += "DynamicData     Succeed   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Commit!" + " \n";
                        }
                        catch (SQLiteException se)
                        {
                            dbTrans.Rollback();
                            mw.testBox.Text += "DynamicData     Fail  " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data + " \n";
                            //return false;
                        }
                        catch (ArgumentException ae)
                        {
                            dbTrans.Rollback();
                            mw.testBox.Text += "DynamicData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace + "\n\n" + ae.Data + " \n";
                            // return false;
                        }
                        catch (Exception ex)
                        {
                            dbTrans.Rollback();
                            //Do　any　logging　operation　here　if　necessary  
                            mw.testBox.Text += "DynamicData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ex.Message + "\n\n" + ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.Data + " \n";
                            // return false;
                        }
                        catch
                        {
                            dbTrans.Rollback();
                            mw.testBox.Text += "DynamicData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  Rollback!" + " \n";
                        }



                    }

                }
                //SQLiteCommand cmd = conn.CreateCommand();
                //cmd.CommandText = "INSERT INTO Book(ID, BookName, Price, Rowguid) VALUES(@ID1, @BookName1, @Price1, @Rowguid1)";
                //cmd.Parameters.Add(new SQLiteParameter("ID1", book.ID));
                //cmd.Parameters.Add(new SQLiteParameter("BookName1", book.BookName));
                //cmd.Parameters.Add(new SQLiteParameter("Price1", book.Price));
                //cmd.Parameters.Add(new SQLiteParameter("Rowguid1", book.Rowguid));

                //int i = cmd.ExecuteNonQuery();
                //return i == 1;
            }
            catch (SQLiteException se)
            {

                mw.testBox.Text += "DynamicData     Fail  " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + se.Message + " \n\n" + se.Source + "\n\n" + se.StackTrace + "\n\n" + se.Data + " \n";
                //return false;
            }
            catch (ArgumentException ae)
            {
                mw.testBox.Text += "DynamicData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace + "\n\n" + ae.Data + " \n";
                // return false;
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                mw.testBox.Text += "DynamicData     Fail   " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "      " + ex.Message + "\n\n" + ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.Data + " \n";
                // return false;
            }
        }

       
    }
}
