﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[BsonIgnoreExtraElements]
public class Librarian : User
{
    public Librarian(string id, string userName, string password, string firstName, string lastName) : base(id, userName, password, firstName, lastName)
    {
        this.IsAdmin = true;
    }

    public List<Member> getAllMembers()
    {
        List<Member> members = new List<Member>();
        var users = LibraryDatabase.getRecords<User>("Users").FindAll(u => u is Member);
        foreach (var user in users)
        {
            members.Add(user as Member);
        }

        return members;
    }

    public void addNewMember(string id, string username, string password, string firstName, string lastname)
    {
        Member member = new Member(id, username, password, firstName, lastname);
        LibraryDatabase.insertRecord<User>("Users", member);
        MessageBox.Show("Member added successfully", "Member Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void editMemberDetail(string id, string firstName, string lastName)
    {
        Member member = LibraryDatabase.getRecordBy<User>("Users", id) as Member;

        member.FirstName = firstName;
        member.LastName = lastName;

        LibraryDatabase.updateRecord<User>("Users", id, member);
    }

    public void deleteMemberDetail(string id)
    {

        Member member = LibraryDatabase.getRecordBy<Member>("Users", id);

        if (member.BorrowedBooksISBN.Count > 0)
        {
            MessageBox.Show($"Member can not delete since {member.BorrowedBooksISBN.Count} books are being borrow this member!", "Delete Prohibited!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (member != null)
        {
            LibraryDatabase.deleteRecord<User>("Users", id);
            MessageBox.Show("Member Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Member not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public override void borrowBook(string isbn, string memberId)
    {
        try
        {
            Member targetMember = LibraryDatabase.getRecordBy<User>("Users", memberId) as Member;
            if (targetMember is Member)
            {
                targetMember.borrowBook(isbn, targetMember.Id);
            }
            else
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch
        {
            MessageBox.Show("Book or Member not found in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public override void returnBook(string isbn, string memberId)
    {
        try
        {
            Member targetMember = LibraryDatabase.getRecordBy<User>("Users", memberId) as Member;
            if (targetMember is Member)
            {
                targetMember.returnBook(isbn, targetMember.Id);
            }
            else
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        catch
        {
            MessageBox.Show("Book or Member not found in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}