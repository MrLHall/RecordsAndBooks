Module Module1
    Structure book 'creates a new structure for records
        Dim title As String
        Dim author As String
        Dim genre As String
        Dim pageCount As Integer
        Dim available As Boolean '5 attributes with their data type

        Sub New(utitle As String, uauthor As String, ugenre As String, upageCount As Integer, uavailable As Boolean) 'create a method to create a new record
            title = utitle
            author = uauthor
            genre = ugenre
            pageCount = upageCount
            available = uavailable 'assignes each argument to each of the attributes of the record
        End Sub
    End Structure
    Sub Main()
        Dim ofMiceAndMen As New book("Of Mice and Men", "John Steinbeck", "Classic literature", 128, True)
        Dim Silmarillion As New book("The Silmarillion", "J. R. R. Tolkien", "Fantasy", 448, False)
        Dim GOT As New book("A Game of Thrones", "George R.R. Martin", "Fantasy", 864, True)
        Dim Hygge As New book("The Little Book of Hygge", "Meik Wiking", "Healthy Living", 288, True) 'create 4 records with their given data

        Dim usersBook As book ' blank record for a new book to add later
        Console.WriteLine("what is the title of your book")
        usersBook.title = Console.ReadLine() 'reads the users input and assignes it to the given attribute of the record
        Console.WriteLine("what is the author of your book")
        usersBook.author = Console.ReadLine() 'reads the users input and assignes it to the given attribute of the record
        Console.WriteLine("what is the genre of your book")
        usersBook.genre = Console.ReadLine() 'reads the users input and assignes it to the given attribute of the record
        Console.WriteLine("what is the page count of your book")
        usersBook.pageCount = Console.ReadLine() 'reads the users input and assignes it to the given attribute of the record
        usersBook.available = False
        'Console.WriteLine(usersBook.title)
        'Console.WriteLine(usersBook.author)
        'Console.WriteLine(usersBook.genre)
        'Console.WriteLine(usersBook.pageCount)
        'Console.WriteLine(usersBook.available)

        Dim library() As book = {ofMiceAndMen, Silmarillion, GOT, Hygge, usersBook} 'create an array with all the books 
        Console.WriteLine(library(1)) ' does not work, whole records can not be called
        Console.WriteLine(library(1).title) ' we can call specific attributes

        library(3).available = False 'update the avalibility to a new value
        Console.WriteLine(library(1).pageCount) 'output old pagecount to test
        library(1).pageCount = library(1).pageCount + 50 'updating value of page count by 50
        Console.WriteLine(library(1).pageCount) 'output new number to test

    End Sub

End Module
