
Option Strict On

''' <summary>
''' Author Name:    Evan Heath [Student ID: 100710750]
''' Project Name:   Vehicle List
''' Date:           March 15th, 2019
''' Description     An application that can take and update records of vehicles. It saves the data about each car to a class and saves
'''                 the vehicle objects to a collection.
''' </summary>

Public Class frmVehicleList

    ' Collection of Vehicles
    Private vehicleList As New Collection

    ' A variable to check if editing is okay
    Dim editingWhich As Integer = -1

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a customer object will be create using the  
    '''                - parameterized constructor. It will also insert the new customer object
    '''                - into the customerList collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific customer object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Check to see if the inputs are valid
        If IsValidInput() Then

            If editingWhich = -1 Then

                ' Declare a new vehicle
                Dim newVehicle As New Vehicle(chkNew.Checked, cmbMakes.SelectedItem.ToString, Trim(tbxModel.Text), cmbYear.SelectedItem.ToString, Double.Parse(tbxPrice.Text))

                ' Add the new vehicle to the collection
                vehicleList.Add(newVehicle)

                ' Tell the user that the car was added, even though they can see it
                lblResult.Text = newVehicle.Year.ToString + " " + newVehicle.Make + " " + newVehicle.Model + " added to the list."

            Else

                Dim editVehicle As Vehicle = CType(vehicleList.Item(editingWhich), Vehicle)

                editVehicle.NewStatus = chkNew.Checked
                editVehicle.Make = cmbMakes.SelectedItem.ToString
                editVehicle.Model = tbxModel.Text
                editVehicle.Year = cmbYear.SelectedItem.ToString
                editVehicle.Price = Double.Parse(tbxPrice.Text)


            End If

            ' Clean the input table
            Reset()

            ' Clean the listview
            lvwVehicles.Items.Clear()

            ' Itterate through each vehicle and post it to the list view
            For index As Integer = 1 To vehicleList.Count

                ' Declare a LVI
                Dim LVI = New ListViewItem()

                ' Use a variable to save a reference to the current vehicle being posted
                Dim addVehicle = CType(vehicleList.Item(index), Vehicle)

                ' Add the elements to the list view
                LVI.Checked = addVehicle.NewStatus
                LVI.SubItems.Add(addVehicle.Identification.ToString)
                LVI.SubItems.Add(addVehicle.Make)
                LVI.SubItems.Add(addVehicle.Model)
                LVI.SubItems.Add(addVehicle.Year)
                LVI.SubItems.Add(addVehicle.Price.ToString("c2"))

                ' Send the LVI to thelist view
                lvwVehicles.Items.Add(LVI)

                ' Check if needed
                ' lvwVehicles.Items(index - 1).Checked = addVehicle.NewStatus

            Next

        Else
            lblResult.Text = " A Value(s) given have an improper value, please make sure the dropdown lists have an item selected, and the price is a number without the '$' sign"
        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()

        cmbMakes.SelectedItem = Nothing
        cmbYear.SelectedItem = Nothing
        tbxModel.Text = String.Empty
        tbxPrice.Text = String.Empty
        chkNew.Checked = False

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        ' Empty the Result label
        lblResult.Text = String.Empty

        ' Validate that a maker was chosen
        If cmbMakes.SelectedItem Is Nothing Then
            lblResult.Text += "A car maker needs to be selected. "
        End If

        ' Validate that the car model has a name
        If Trim(tbxModel.Text) Is Nothing Or tbxModel.Text Is String.Empty Then
            lblResult.Text += "The car needs a model name. "
        End If

        ' Validate a year was specified
        If cmbYear.SelectedItem Is Nothing Then
            lblResult.Text += "The car year needs to be selected. "
        End If

        ' Validate that price is valid
        Dim parsedPrice As Double
        ' Is the price a real number
        If Not Double.TryParse(tbxPrice.Text, parsedPrice) Then
            ' Price is invalid
            lblResult.Text += "The given price is invalid. "
        End If

        ' Return a boolean based on if an erro was posted
        Return lblResult.Text Is String.Empty

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset the form using the reset function
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Close the form (Cause its Visual Basic)
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwVehicles_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwVehicles.ItemCheck

        If editingWhich > -1 Then

            ' Reset the check
            e.NewValue = Not e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwVehicles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwVehicles.SelectedIndexChanged

        If lvwVehicles.FocusedItem IsNot Nothing Then

            Const IdentificationPosition As Integer = 1

            editingWhich = Integer.Parse(lvwVehicles.Items(lvwVehicles.FocusedItem.Index).SubItems(IdentificationPosition).Text)

            Dim selectedVehicle As Vehicle = CType(vehicleList.Item(editingWhich), Vehicle)

            chkNew.Checked = selectedVehicle.NewStatus
            cmbMakes.Text = selectedVehicle.Make
            tbxModel.Text = selectedVehicle.Model
            cmbYear.Text = selectedVehicle.Year
            tbxPrice.Text = selectedVehicle.Price.ToString

        End If
    End Sub

    'Private Sub lvwCustomers_Click(sender As Object, e As EventArgs) Handles lvwCustomers.Click
    '    lbResult.Text = "aaa"
    'End Sub
End Class

