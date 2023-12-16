﻿
Imports WinFormsApp2.Erenjhun.Utils

Namespace AddEmpformStates

    Class RecognizedFaceFoundState
        Inherits Erenjhun.Utils.RecognizedFaceFoundState
        Public Overrides Sub Enter()

            If Face_name(curr_face_id) = Face_name() Then Exit Sub 'if face detected is the same as last then skip
            'if new recognized face is detected
            Dim addform As addEmployee = Form
            addform.status_lb.Text = "READY"
            curr_face_id = Face_id
        End Sub



    End Class

    Class FindingState
        Inherits Erenjhun.Utils.FindingState
        Public Overrides Sub enter()
            If manager.prev_state.before.key = key Then Exit Sub
            Dim addform As addEmployee = Form
            addform.cam_pic_box.BackColor = Color.Red
        End Sub
    End Class


    Class UnrecognizedFaceFoundState
        Inherits Erenjhun.Utils.UnrecognizedFaceFoundState
        Public Overrides Sub Enter()
            If manager.prev_state.before.key = key Then Exit Sub
            Dim addform As addEmployee = Form
            addform.cam_pic_box.BackColor = Color.LightGreen
            addform.status_lb.Text = "READY"
        End Sub
    End Class
End Namespace
