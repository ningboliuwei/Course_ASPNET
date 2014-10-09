<%@ Page Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Book_Detail.aspx.cs" Inherits="_Default" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style>
         body{
  margin:0px;
  }
        </style>
        <div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal"
            DataKeyField="StudentID" onitemcommand="DataList1_ItemCommand">
            <ItemTemplate>
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lbInformation" Text='<%#Eval("BookInformation")%>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 200px; height: 200px">
                            <asp:Image ID="imgBook" runat="server" ImageUrl='<%#"Admin/upload/" + Eval("BookPhoto")%>'
                                Width="140px" Height="140px" />
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        商品昵称：<asp:Label runat="server" ID="lbBookName" Text='<%#Eval("BookName")%>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        价格： <span style="color: #ff7f50">&nbsp;&nbsp;&nbsp;￥</span><asp:Label runat="server"
                                            ID="lbPrice" Text='<%#Eval("BookPrice")%>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        运费：<asp:Label runat="server" ID="lbFare" Text='<%#Eval("BookFare")%>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        关注度：<asp:Label runat="server" ID="lbAttention" Text='<%#Eval("Attention")%>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>购买数量<asp:TextBox ID="tetbuy" runat="server" Height="20px" Width="40px"></asp:TextBox>
                                        件</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:ImageButton ID="ImgBuy" runat="server" ImageUrl="images/加入购物车.jpg" 
                                            Width="82px" onclick="ImgBuy_Click" />
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/立刻购买.jpg" 
                                            Width="88px" onclick="ImageButton1_Click" />
                                        
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>

