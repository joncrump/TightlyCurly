<%@ Page Language="C#" MasterPageFile="~/MasterPages/Master.master" Culture="auto:en-US" AutoEventWireup="true" CodeBehind="Ingredients.aspx.cs" Inherits="TightlyCurly.Com.Web.Ingredients" %>
<%@ Register Src="~/UserControls/IngredientsControl.ascx" TagName="IngredientsControl" TagPrefix="Alligoshee" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <div id="blurb" runat="server" style="width:700px;">
    <br />
    <br />
    <br />
        <asp:Panel ID="Preamble" runat="server">
            I&#8217;ve tried to gather the most accurate descriptions of hair care ingredients as I can find. I&#8217;ve used what I believe to be the most objective sources for my information. I've also tried to include notes of where I found the information, as well as what I&#8217;ve found through my own experimentation. This list is geared towards how ingredients would affect very curly hair. As I discover new information, and better sources, I&#8217;ll add to or adjust this list accordingly. Believe me, I&#8217;m adding constantly to this 
            list.
            <br />
            <br/>
             I try to be as accurate as possible, but know that every curly person is different, and what I find to be true for me may not be the same for you.
             <br />
             <br /> 
        </asp:Panel>
        In the ingredient descriptions: <span class="good">Good</span> means that I like to see this in a product's list of ingredients.  <span class="acceptable">Okay</span> means this product appears safe for a curly person like me to use. <span class="caution">Caution</span> means that this ingredient may not be good in some hair care products, or for some people. <span class="avoid">Avoid</span> means this ingredient may hurt your hair. If you see this ingredient in a hair product, it's best to put it down and walk away. 
        <br />
        <br />
    </div>
    <div style="width:100%;text-align:center">
        <Alligoshee:IngredientsControl ID="ingredients" runat="server" />
    </div>
    <br />
    <br />
    <div style="width:700px;">
        <p class="bodyEmphasis">
            References:
        </p>
        <p>
            <a name="Applewhite" class="referenceAnchor">Applewhite, Thomas H., ed.</a> <i><a href="http://www.amazon.com/gp/product/093531556X?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=093531556X">Proceedings of the World Conference on Lauric Oils: Sources, Processing, and Applications</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=093531556X" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i>
            <br />
            AOCS Publishing, 1994.
        </p> 
        <p>   
            <a name="Barel" class="referenceAnchor">Barel, André O., Marc Paye, and Howard I. Maibach., eds.</a> <i><a href="http://www.amazon.com/gp/product/1574448242?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1574448242">Handbook of Cosmetic Science and Technology, Second Edition</a></i>
            <br />
            Marcel Dekker, Inc., 2001.
        </p>
        <p>
         
            <a name="Begoun" class="referenceAnchor">Begoun, Paula.</a> <a href="http://www.amazon.com/gp/product/1877988316?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1877988316"><span class="paragraph Free_Form" style="line-height: 17px; margin-bottom: 0px; margin-top: 0px; line-height: 17px;  text-decoration: none;"><a href="http://www.amazon.com/gp/product/1877988316?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1877988316"><i>Don&#8217;t Go Shopping for Hair-Care Products Without Me. 3rd Edition.</i></a></span></a>
            <br />
            Renton: Beginning Press, 2005.
        </p>
        <p>
            <a name="Begoun (Beauty)" class="referenceAnchor">Begoun, Paula.</a> <i><a href="http://www.paulaschoice.com/product/the-beauty-bible/books?a=telzeek">The Beauty Bible.</a></i>
            <br />
            Renton: Beginning Press, 2002.
        </p>
        <p>
            <a name="Begoun (Cosmetics)" class="referenceAnchor">Begoun, Paula.</a> <i><a href="http://www.paulaschoice.com/product/dont-go-cosmetics-counter-without-me/books?a=telzeek">Don&#8217;t Go to the Cosmetics Counter Without Me.</a></i>
            <br />
            Renton: Beginning Press, 2003.
            
        </p>
        <p>
        <a name="Beauty Brains" class="referenceAnchor">Bellum, Sarah, ed.</a> <i><a href="http://www.amazon.com/gp/product/0980217342?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=0980217342">The Beauty Brains: Real Scientists Answer Your Beauty Questions</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=0980217342" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i>

            <br />
            New York: Brains Publishing, 2008.
        </p> 
        <p>
            <a name="Gottschalk" class="referenceAnchor">Gottschalk, Tari E. and McEwen, Gerald N, Jr. PhD, eds.</a> <i><a href="http://www.amazon.com/gp/product/1882621433?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1882621433">International Cosmetic Ingredient Dictionary and Handbook, Tenth Edition 2004, Volumes 1-4.</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=1882621433" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i> 
            <br />
            Washington D. C.: The Cosmetic, Toiletry, and Fragance Association, 2004.
        </p>
        <p>
            <a name="Halal" class="referenceAnchor">Halal, John</a> <i><a href="http://www.amazon.com/gp/product/1428335587?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1428335587">Hair Structure and Chemistry Simplified, Fifth Edition</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=1428335587" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i> 
            <br />
            Albany: Milady, 2002.
        </p>
        <p>
            <a name="Hunting" class="referenceAnchor">Hunting, Anthony L.L. </a> <i>Encyclopedia of Conditioning Rinse Ingredients.</i>
            <br />
           Cranford, NJ: Micelle Press, Inc., 1987.  
        </p>
         <p>
            <a name="Hunting" class="referenceAnchor">Hunting, Anthony L.L. </a> <i>Encyclopedia of Shampoo Ingredients.</i>
            <br />
           Cranford, NJ: Micelle Press, Inc., 1983.  
        </p>

        <p> 
            <a name="Nnanna" class="referenceAnchor">Nnanna, Ifendu A. and Jiding Xia., eds.</a> <i><a href="http://www.amazon.com/gp/product/082470004X?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=082470004X">Protein-Based Surfactants: Synthesis: Physicochemical Properties, and Applications (Surfactant Science)</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=082470004X" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i>
            <br />
            Madison Heights: CRC, 2001.
        </p>
        <p>
            <a name="Quadflieg" class="referenceAnchor">Quadflieg, Jutta Maria.</a> <i>Fundamental properties of Afro-American hair as related to their straightening/relaxing behaviour.</i>
            <br />
            Diss. U of Rheinisch-Westf&#228;lischen Technischen Hochschule Aachen, 2003.  
        </p>
        <p>
            <a name="Schueller" class="referenceAnchor">Schueller, Randy and Perry Romanowski, eds.</a> <i>Conditioning Agents for Hair and Skin.</i>
            <br />
            New York: Marcel Dekker, Inc., 1999.  
        </p>
        <p>
            <a name="Winter" class="referenceAnchor">Winter, Ruth M.S.</a> <i><a href="http://www.amazon.com/gp/product/1400052335?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=1400052335">A Consumer's Dictionary of Cosmetic Ingredients: Complete Information About the Harmful and Desirable Ingredients Found in Cosmetics and Cosmeceuticals</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=1400052335" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i> 
            <br />
            New York: Three Rivers Press, 2005.
        </p>
        <p>
            <a name="Zviak" class="referenceAnchor">Zviak, Charles., ed.</a> <i><a href="http://www.amazon.com/gp/product/0824773780?ie=UTF8&tag=birhaiubecurh-20&linkCode=as2&camp=1789&creative=9325&creativeASIN=0824773780">The Science of Hair Care (Dermatology)</a><img src="http://www.assoc-amazon.com/e/ir?t=birhaiubecurh-20&l=as2&o=1&a=0824773780" width="1" height="1" border="0" alt="" style="border:none !important; margin:0px !important;" /></i> 
            <br />
            New York: Marcel Dekker, Inc., 1986.
        </p>
    </div>
</asp:Content>
