﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class LinkManagerDAL {
        public static List<FileLink> GetLinks() {
            string select = "Select LinkMemoID, sLinkMemo As LinkMemo From LinkMemos " +
                "Where dMemoDeleted Is Null";
            return Db.ReadQuery<FileLink>(select);
        }

        public static FileLink GetLink(int linkMemoID) {
            if (linkMemoID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            string select = "Select LinkMemoID, sLinkMemo As LinkMemo From LinkMemos " +
                "Where dMemoDeleted Is Null And LinkMemoID = @LinkMemoID";
            List<FileLink> results = Db.ReadQuery<FileLink>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static int AddLink(List<int> fileIDs, string linkMemo) {
            // Create the link group
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Memo", linkMemo));
            string insert = "Insert Into LinkMemos (sLinkMemo, dMemoCreated, dMemoUpdated) " +
                "Values (@Memo, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            // Add list of files to the group
            foreach (int id in fileIDs) {
                FileLinkDAL.Join(newID, id);
            }
            return newID;
        }

        public static int AddLink(List<int> fileIDs) {
            // Create the link group (without setting up a memo)
            string insert = "Insert Into LinkMemos (dMemoCreated, dMemoUpdated) " +
                "Values (GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert);
            // Add list of files to the group
            foreach (int id in fileIDs) {
                FileLinkDAL.Join(newID, id);
            }
            return newID;
        }
    }
}
