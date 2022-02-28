Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'PRIMERO REALIZAMOS EL CALCULO DEL FACTORIAL

        Dim lector As Integer 'variable que guarda el numero en el textbox
        Dim numero As Integer 'variable para los ciclos del factorial
        Dim numfacto As Integer 'var para el factorial
        Dim res1 As String = ""
        Dim cantmult4 As Integer = 0
        numfacto = 1
        lector = TextBox1.Text 'leemos el textbox
        'realizamos iteraciones tantas veces como el numero al que queremos
        'averiguar el factorial
        For numero = 1 To lector Step 1
            numfacto = numfacto * numero
        Next


        'UNA VEZ TENEMOS EL FACTORIAL CREAMOS UN CICLO QUE CALCULE LOS
        'MULTIPLOS DE 4

        Dim indice = 0
        While (indice <= numfacto) 'El ciclo se repite tanto como el factorial


            If (indice Mod 4 = 0) Then 'Condicion de factores de 4
                res1 = res1 + indice.ToString + "," 'Esto muestra los 
                'factores UNO POR UNO en una textbox

                cantmult4 = cantmult4 + 1 'Esto encuentra el TOTAL de factores
                'que cumplen la condicion
            End If

            indice = indice + 1 'Suma 1 al ciclo
        End While

        'Visualización:
        TxtRES.Text = res1
        MsgBox("Cantidad de multiplos de 4= " & cantmult4.ToString)

    End Sub
End Class
