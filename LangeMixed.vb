Public Class LangMixed
  Public Function ThisTripsAnotherLanguageFilterMaybe (what as String)
    Dim sql as String
    sql = "SELECT * FROM table WHERE " + what
    Return sql
  End Sub
End Class
