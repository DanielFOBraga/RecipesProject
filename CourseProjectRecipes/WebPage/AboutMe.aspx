<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="AboutMe.aspx.cs" Inherits="WebPage.AboutMe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- About Me Section Begin -->
    <section class="about-me spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="about-left">
                        <img src="img/Profile-photo.jpg" alt="">
                        <div class="about-title">
                            <span>1 January 2020</span>
                            <h2>I’m Daniel Braga, <br /> and this is my Recipes portal project</h2>
                            <p class="text-justify">In the context of the Code Developer academy at Galileu I created this recipes portal 
                                project. It uses .NET Framework webforms for the frontend and Windows forms for the 
                                backend management. The data is stored in a SQL server. The visual aspect of the portal 
                                is based on a Colorlib HTML and Bootstrap template.
                            </p>
                            <p class="text-justify">Donec sit amet enim tortor. Sed egestas nulla nibh, vitae porta velit sagittis eget.
                                Donec vitae tellus semper, cursus sem id, iaculis purus. Aenean ligula risus, maximus
                                tristique eros vel, auctor ornare tortor. Aliquam vel augue sapien. Duis non auctor
                                ante, ac vestibulum tortor. Etiam quis dolor ultricies, dignissim ante a, ornare ipsum.
                                Phasellus suscipit rhoncus nulla, quis bibendum tortor elementum ac. Nullam viverra
                                tellus diam, nec accumsan orci aliquam sed. Sed placerat sagittis lacus, non rutrum diam
                                volutpat id. </p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="about-right">
                        <div class="sidebar">
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-1.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>One Pot Weeknight Lasagna Soup Recipe</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-2.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>Lava Cake with a Tone of Chocolate</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-3.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>One Pot Weeknight Lasagna Soup Recipe</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-4.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>Smoked Salmon mini Sandwiches with Onion</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-5.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>Asparagus with Pork Loin and Vegetables</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-6.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>Dry Cookies with Corn</h6>
                                </div>
                            </div>
                            <div class="sidebar-item">
                                <a href="#"><img src="img/cat-feature/small-7.jpg" alt=""></a>
                                <div class="sidebar-item-text">
                                    <div class="cat-name">Vegan</div>
                                    <h6>Italian Tiramisu with Coffe</h6>
                                </div>
                            </div>
                        </div>
                        <div class="about-right-add set-bg" data-setbg="img/about-right.jpg">
                            <h4>Buy my Cook Book</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- About Me Section End -->

    <!-- Similar Recipe Section Begin -->
    <section class="similar-recipe spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#"><img src="img/cat-feature/small-7.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Italian Tiramisu with Coffe</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#"><img src="img/cat-feature/small-6.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Dry Cookies with Corn</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#"><img src="img/cat-feature/small-5.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Asparagus with Pork Loin and Vegetables</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#"><img src="img/cat-feature/small-4.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Smoked Salmon mini Sandwiches with Onion</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Similar Recipe Section End -->
</asp:Content>
