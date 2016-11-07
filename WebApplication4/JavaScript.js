var moreBook = function () {
    console.log("test");
    var tr = new TableRow();

    var tc = new TableCell();
    tc.Text = "Book Number";

    var tc2 = new TableCell();
    var tbNum = new TextBox();
    tbNum.ID = "numBook" + counter;
    tc2.Controls.Add(tbNum);

    var tc3 = new TableCell();
    tc3.Text = "Amount";

    var tc4 = new TableCell();
    var tbNum2 = new TextBox();
    tbNum2.ID = "quantity" + counter;
    tc4.Controls.Add(tbNum2);

    tr.Cells.Add(tc);
    tr.Cells.Add(tc2);
    tr.Cells.Add(tc3);
    tr.Cells.Add(tc4);

    $get("Table3").Rows.Add(tr);
}
  