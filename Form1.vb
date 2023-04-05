Public Class Form1

    'Form level members
    Private ReadOnly objCustomers As New CustomerCollection
    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If LstCustomers.SelectedIndex <> -1 Then
                'Return the selected customer
                Return LstCustomers.Items(LstCustomers.SelectedIndex)
            End If
        End Get
    End Property
    Public Sub CreateCustomer(ByVal firstName As String, ByVal lastName As String, ByVal email As String)

        'Declare a Customer object
        Dim objNewCustomer As Customer

        'Create a new customer
        objNewCustomer.Firstname = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        LstCustomers.Items.Add(objNewCustomer)
    End Sub
    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click

        'Create some customers
        CreateCustomer("Darrel", "Hilton", "dhilton@somecompany.com")
        CreateCustomer("Frank", "Peoples", "fpeoples@somecompany.com")
        CreateCustomer("Bill", "Scott", "bscott@somecompany.com")
        'Display the customer
        'DisplayCustomer(objCustomer)
    End Sub
    Public Sub DisplayCustomer(ByVal customer As Customer)
        'Display the customer details on the form
        TxtName.Text = customer.Name
        TxtFirstName.Text = customer.Firstname
        TxtLastName.Text = customer.LastName
        TxtEmail.Text = customer.Email
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'If no customer is selected in the ListBox then...
        If LstCustomers.SelectedIndex = -1 Then

            'Display a message
            MessageBox.Show("You must select a customer to delete.", "Structure Demo")

            'Exit this method
            Exit Sub
        End If

        'Prompt the user to delete the selected customer
        If MessageBox.Show("Are you sure you want to delete " & SelectedCustomer.Name & "?", "Structure Demo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Get the customer to be deleted
            Dim objCustomerToDelete As Customer = SelectedCustomer

            'Remove the customer from the ArrayList
            objCustomers.Remove(objCustomerToDelete)

            'Remove the customer from the ListBox
            LstCustomers.Items.Remove(objCustomerToDelete)
        End If
    End Sub

    Private Sub LstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstCustomers.SelectedIndexChanged

        'Display the customer details
        DisplayCustomer(SelectedCustomer)
    End Sub
End Class
