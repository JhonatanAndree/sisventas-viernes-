Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, apellidos, direccion, telefono, dni As String

    'implementaremos metodos seeter (guarda datos en cualquiera de los atributos que son objeto en memoria)
    'y getter (lee los atributos que se encuentran en memoria contida)
    'aplicamos un metodo seeter y un getter por cada campo:
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property

    'ahora creamos constructores, quienes seràn los que reciben los datos y se comunican con la carpeta datos para ejecutar los CRUD
    'crearemos dos constructores, el primero en blanco y otro con datos
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal dni As String)
        'ahora definimos donde guardar
        gidcliente = idcliente
        gnombre = nombre
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gdni = dni
    End Sub
    'creados los métodos procedemos a crear los procedimientos almacenados en nuestra base de datos
End Class
