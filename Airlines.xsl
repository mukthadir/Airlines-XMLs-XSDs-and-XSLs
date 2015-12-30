<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:template match="/">
        <html>
            <body>
                <h1> Airlines </h1>
                <table border = "1">
                    <tr bgcolor = "red">
                        <td> <b> Name </b> </td>
                        <td> <b> International Flight </b> </td>
                        <td colspan = "2"> <b> Reservation (Phone/ Url) </b> </td>
                        <td colspan = "3"> <b> Headquarter (City/ State/ Zip) </b> </td>
                        <td> <b> Alliance </b> </td>
                    </tr>
                    <xsl:for-each select = "Airlines/Airline">
                        <xsl:sort select="Name" />
                        <tr style = "font-size: 10pt; font-family: verdana">
                            <td><xsl:value-of select="Name"/></td>
                            <td><xsl:value-of select="@InternationalFlight"/></td>
                            <td><xsl:value-of select="Reservation/Phone"/></td>
                            <td><xsl:value-of select="Reservation/Url"/></td>
                            <td><xsl:value-of select="Headquarter/City"/></td>
                            <td><xsl:value-of select="Headquarter/State"/></td>
                            <td><xsl:value-of select="Headquarter/@zip"/></td>
                            <td><xsl:value-of select="Alliance"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>