
open System.Windows.Forms

let grid (prices:seq<System.DateTime * float>)=
    let form = new Form(Visible=true,TopMost=true)
    let grid= new DataGridView(Dock=DockStyle.Fill,Visible=true)
    form.Controls.Add(grid)
    grid.DataSource <- prices |> Seq.toArray
