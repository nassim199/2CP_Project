﻿Public Class RechercheEtudiantView

    Public Sub New()

        InitializeComponent()



    End Sub

    Private Sub PrenomChangedfr(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        If PrenomfrTB.Text.Length = 0 Then
            PrenomHintfr.Visibility = Windows.Visibility.Visible
        Else
            PrenomHintfr.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    Private Sub NomChangedfr(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        If NomfrTB.Text.Length = 0 Then
            NomHintfr.Visibility = Windows.Visibility.Visible
        Else
            NomHintfr.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    Private Sub WilayaChanged(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        If WilayaTB.Text.Length = 0 Then
            WilayaHint.Visibility = Windows.Visibility.Visible
        Else
            WilayaHint.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    Private Sub PromoChanged(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        If PromoTB.Text.Length = 0 Then
            PromoHint.Visibility = Windows.Visibility.Visible
        Else
            PromoHint.Visibility = Windows.Visibility.Hidden
        End If

    End Sub

    Private Sub MatriculeChanged(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        If MatriculeTB.Text.Length = 0 Then
            MatriculeHint.Visibility = Windows.Visibility.Visible
        Else
            MatriculeHint.Visibility = Windows.Visibility.Hidden
        End If

    End Sub

    'just for test 
    Private Sub thisONe(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
        Dim Etudiants As List(Of Etudiant) = New List(Of Etudiant)()
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })
        Etudiants.Add(New Etudiant() With {
            .Nom = "hakim",
            .Prenom = "addjou",
            .Matricule = "123456",
            .DateNais = New DateTime(2000, 7, 23),
            .LieuNais = "alger",
            .AnnIns = 2018
        })


        Mygrid.ItemsSource = Etudiants
    End Sub

    Private Sub comboBox_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim list As New List(Of String)
        list.Add("Masculin")
        list.Add("Feminin")
        SexeCB.ItemsSource = list
    End Sub

    Private Sub cbTest_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles SexeCB.SelectionChanged

    End Sub
End Class
