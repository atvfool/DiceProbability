<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="DiceProbabiity._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblNumberOfDice" runat="server" Text="Number Of Dice" />
            <asp:TextBox ID="txtNumberOfDice" runat="server" TextMode="Number" />
            <br />
            <asp:Label ID="lblNumberOfSides" runat="server" Text="Number Of Sides" />
            <asp:TextBox ID="txtNumberOFSides" runat="server" TextMode="Number" />
            <br />
            <asp:Label ID="lblNumberOfDesiredResults" runat="server" Text="Number Of Desired Results" />
            <asp:TextBox ID="txtNumberOfDesiredResults" runat="server" TextMode="Number" />
            <br />
            <asp:Button ID="btnAddDiceToPool" runat="server" Text="Add Dice To Pool" />
        </div>
    </form>
    <%If m_lstDice.Count > 0 Then%>
        <table class="table">
            <thead>
                <tr>
                    <th># Of Sides</th>
                    <th># Of Dice</th>
                    <th># Of Desired Results</th>
                    <th>100% Probability</th>
                </tr>
            </thead>
            <tbody>
                <%For Each die As DiceLibrary.CDice In m_lstDice %>
               <tr>
                   <td><%=die.NumberOfSides %></td>
                   <td><%=die.NumberOfDice %></td>
                   <td><%=die.DesiredResult %></td>
                   <td><%=DiceLibrary.CDiceProbability.GetProbability(die) %></td>
               </tr>
                <%Next %>
            </tbody>
        </table>
    <% End If %>

    <%If m_lstRolling.Count > 0 Then %>
        <table class="table">
            <thead>
                <tr>
                    <th># Of Dice</th>
                    <th>Probability</th>
                </tr>
            </thead>
            <tbody>
                <%For each pair As DiceLibrary.CIntegerDecimalPair In m_lstRolling %>
                <tr>
                    <td><%=pair.Number %></td>
                    <td><%=pair.Percentage %></td>
                </tr>
                <%Next %>
            </tbody>
        </table>
    <%End If %>
</body>
</html>
