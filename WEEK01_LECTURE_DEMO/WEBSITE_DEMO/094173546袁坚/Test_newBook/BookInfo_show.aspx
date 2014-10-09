<%@ Page Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="BookInfo_show.aspx.cs" Inherits="_Default" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

        <div >
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"
            DataKeyField="BookID" >
            <ItemTemplate>
                <table width="200px" >
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Image ID="imgBook" runat="server" ImageUrl='<%#"Admin/upload/" + Eval("BookPhoto")%>'
                                Width="140px" Height="140px"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                        &nbsp;&nbsp;&nbsp;
                            <a href='Book_Detail.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BookID") %>&price=<%#DataBinder.Eval(Container.DataItem,"BookPrice")%>'>
                                <%#DataBinder.Eval(Container.DataItem, "BookInformation")%>
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <span style="color:#ff7f50 ">&nbsp;&nbsp;&nbsp;￥</span><asp:Label runat="server" ID="lbPrice" Text='<%#Eval("BookPrice")%>' />
                        </td>
                        <td style="font-size: 10px">
                            运费：<asp:Label runat="server" ID="lbFare" Text='<%#Eval("BookFare")%>' />
                        </td>
                    </tr>

                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>

