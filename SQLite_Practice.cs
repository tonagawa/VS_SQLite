using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;    // この行を追加する

namespace SQLite_Practice
{
    public partial class Form1 : Form
    {
        // DBのファイルパス
        private readonly string DB_DIR = @"./db";
        private readonly string DB_PATH = @"Data source=./db/dbpractice.db";

        // テーブル名
        private readonly string T_NAME = "practice";


        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_CreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                // DB管理用フォルダの作成
                if (!Directory.Exists(DB_DIR))
                {
                    Directory.CreateDirectory(DB_DIR);
                }

                // DBへ接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }


        private void Btn_CreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                // DBへ接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();

                    // クエリ実行準備
                    SqliteCommand db_command = db_connection.CreateCommand();

                    // SQL文の作成
                    string sql = $"CREATE TABLE IF NOT EXISTS {T_NAME} ( id INTEGER NOT NULL PRIMARY KEY, name TEXT NOT NULL)";

                    // SQL文のセット
                    db_command.CommandText = sql;

                    // クエリ実行
                    db_command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                this.ShowError(ex);
            }
        }


        private void Btn_CheckTable_Click(object sender, EventArgs e)
        {
            try
            {
                // DBへ接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();

                    // クエリ実行準備
                    SqliteCommand db_command = db_connection.CreateCommand();

                    // SQL文の作成
                    string sql = $"PRAGMA TABLE_INFO ({T_NAME})";

                    // SQL文のセット
                    db_command.CommandText = sql;

                    // Table読み込み準備
                    using (SqliteDataReader db_reader = db_command.ExecuteReader())
                    {
                        // Tableをインスタンス化
                        DataTable db_table = new DataTable();
                        db_table.Load(db_reader);

                        // 結果を取得
                        string result = "";

                        // 定義を 1 行ずつ取得（今回の場合、'id'列の定義が 0 行目、'name'列の定義が 1 行目として取得される。列と行が紛らわしい！）
                        foreach (DataRow row in db_table.AsEnumerable())
                        {
                            // 1 行ごとに属性を取得（例えば 0 行目の'id'列なら、『 列番号 0 、列名 id 、データ型 integer 、非nullフラグ 1 、一意制約フラグ 1 』が取得される。こちらも列と行が紛らわしい！）
                            foreach (DataColumn col in db_table.Columns)
                            {
                                // 定義情報を文字列に追加
                                result += $"{col.ColumnName}:{row[col.ColumnName]} ";
                            }

                            // 改行の挿入
                            result += "\r\n";
                        }

                        // 結果表示
                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }


        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                // DBへ接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();

                    // クエリ実行準備
                    SqliteCommand db_command = db_connection.CreateCommand();

                    // テキストボックスの値を取得
                    string selectID = numericUpDown.Value.ToString();
                    string value = tb_Insert.Text;

                    // SQL文の作成
                    string sql = $"INSERT INTO {T_NAME} VALUES ('{selectID}', '{value}');";    // {selectID} と {value} を '' で囲み忘れるとエラーが出る。

                    // SQL文のセット
                    db_command.CommandText = sql;

                    // クエリ実行
                    db_command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }


        private void Btn_Select_Click(object sender, EventArgs e)
        {
            try
            {
                // DBに接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();

                    // クエリ実行準備
                    SqliteCommand db_command = db_connection.CreateCommand();

                    // 検索対象の id を取得
                    string selectID = numericUpDown.Value.ToString();

                    // SQL文の作成
                    string sql = $"SELECT * FROM {T_NAME} WHERE id = {selectID}";

                    // SQL文のセット
                    db_command.CommandText = sql;

                    // クエリ実行結果の取得
                    string result = "";
                    using (SqliteDataReader reader = db_command.ExecuteReader())
                    {
                        // Tableをインスタンス化
                        DataTable db_table = new DataTable();
                        db_table.Load(reader);

                        // 結果を表示用の文字列に追加
                        foreach (DataRow row in db_table.AsEnumerable())
                        {
                            result += $"{row["id"]}, {row["name"]}";
                        }
                    }

                    // 結果の表示
                    lbl_Result.Text = result;
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // DBへ接続
                using (SqliteConnection db_connection = new SqliteConnection(DB_PATH))
                {
                    db_connection.Open();

                    // 削除対象の id を取得
                    string selectID = numericUpDown.Value.ToString();

                    // クエリ実行準備
                    SqliteCommand db_command = db_connection.CreateCommand();

                    // SQL文の作成
                    string sql = $"DELETE FROM {T_NAME} WHERE id = {selectID}";

                    // SQL文のセット
                    db_command.CommandText = sql;

                    // クエリの実行
                    db_command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            { 
                this.ShowError(ex);
            }
        }


        private void ShowError(Exception ex)
        {
            // エラー内容の表示
            MessageBox.Show(ex.ToString());
        }

    }//class
}//namespace
