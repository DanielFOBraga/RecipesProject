﻿<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="RecipeView.aspx.cs" Inherits="WebPage.Recipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Hero Search Section Begin -->
    <div class="hero-search set-bg" data-setbg="img/search-bg.jpg">
        <div class="container">
            <div class="filter-table">
                <div class="filter-search">
                    <input type="text" placeholder="Search recipe">
                    <select id="category">
                        <option value="">Category</option>
                    </select>
                    <select id="tag">
                        <option value="">Tags</option>
                    </select>
                    <button type="submit">Search</button>
                </div>
            </div>
        </div>
    </div>
    <!-- Hero Search Section End -->

    <!-- Single Recipe Section Begin -->
    <section class="single-page-recipe spad">
        <div class="recipe-top">
            <div class="container-fluid">
                <div class="recipe-title">
                    <h2>
                        <asp:Label ID="LabelRecipeText" runat="server" Text="Recipe Title"></asp:Label>

                    </h2>
                    <ul runat="server" id="categoriaReceita" class="tags">
                        <li>Desert</li>
                        <li>Asian</li>
                        <li>Spicy</li>
                    </ul>
                </div>
                <img src="img/recipe-single.jpg" alt="">
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-lg-5">
                    <div class="ingredients-item">
                        <div class="intro-item">
                            <img src="img/intro-img.jpg" alt="">
                            <h2><asp:Label ID="LabelRecipeText2" runat="server" Text="Recipe Title"></asp:Label></h2>
                            <div class="rating">
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                            </div>
                            <div class="reviews">4.9 from 25 reviews</div>
                            <div class="recipe-time">
                                <ul>
                                    <li>Prep time: <span>10 min</span></li>
                                    <li>Cook time: <span>10 min</span></li>
                                    <li>Yield: <span>5</span></li>
                                </ul>
                            </div>
                        </div>
                        <div class="ingredient-list">
                            <div class="recipe-btn">
                                <a href="#">Print Recipe</a>
                                <a href="#" class="black-btn">Pin Recipe</a>
                            </div>
                            <div class="list-item">
                                <h5>Ingredients</h5>
                                <div class="salad-list">
                                    <h6>For the salad</h6>
                                    <ul>
                                        <li>1 brick of frozen udon</li>
                                        <li>1/2 cup kimchi, plus a bit of kimchi juice</li>
                                        <li>1 tablespoon of butter</li>
                                        <li>1 sac of mentaiko</li>
                                        <li>sliced green onions and nori, to finish</li>
                                    </ul>
                                </div>
                                <div class="dressing-list">
                                    <h6>For the dressing</h6>
                                    <ul>
                                        <li>1 brick of frozen udon</li>
                                        <li>1/2 cup kimchi, plus a bit of kimchi juice</li>
                                        <li>1 tablespoon of butter</li>
                                        <li>1 sac of mentaiko</li>
                                        <li>sliced green onions and nori, to finish</li>
                                        <li>1 tablespoon of butter</li>
                                        <li>1 sac of mentaiko</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="nutrition-fact">
                        <div class="nutri-title">
                            <h6>Nutrition Facts</h6>
                            <span>Serves 4</span>
                        </div>
                        <ul>
                            <li>Total Fat : 20.4g</li>
                            <li>Cholesterol : 2%</li>
                            <li>Chalories: 345</li>
                        </ul>
                    </div>
                </div>
                <div class="col-lg-7">
                    <div class="recipe-right">
                        <div class="recipe-desc">
                            <h3>Description</h3>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt
                                ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet. Donec in sodales dui, a
                                blandit nunc. Pellentesque id eros venenatis, sollicitudin neque sodales, vehicula nibh.
                                Nam massa odio, porttitor vitae efficitur non, ultricies volutpat tellus. Cras egestas
                                in lacus a finibus. Suspendisse sed urna at elit condimentum viverra. Suspendisse non
                                lobortis nisi. Maecenas accumsan quam quis porta laoreet. Aliquam felis odio, aliquet
                                fermentum semper at, porttitor ac mi. Duis vel condimentum risus. Phasellus eu dolor vel
                                neque commodo accumsan eget et enim. Pellentesque non elit sed risus tincidunt aliquam
                                eu eget metus.
                            </p>
                            <p>
                                Donec sit amet enim tortor. Sed egestas nulla nibh, vitae porta velit sagittis eget.
                                Donec vitae tellus semper, cursus sem id, iaculis purus. Aenean ligula risus, maximus
                                tristique eros vel, auctor ornare tortor. Aliquam vel augue sapien. Duis non auctor
                                ante, ac vestibulum tortor. Etiam quis dolor ultricies, dignissim ante a, ornare ipsum.
                                Phasellus suscipit rhoncus nulla, quis bibendum tortor elementum ac. Nullam viverra
                                tellus diam, nec accumsan orci aliquam sed. Sed placerat sagittis lacus, non rutrum diam
                                volutpat id.
                            </p>
                        </div>
                        <div class="instruction-list">
                            <h3>Instructions</h3>
                            <ul>
                                <li>
                                    <span>01.</span>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                                    incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet. Donec in
                                    sodales dui, a blandit nunc. Pellentesque id eros venenatis, sollicitudin neque
                                    sodales, vehicula nibh. Nam massa odio, porttitor vitae efficitur non, ultricies
                                    volutpat tellus. Cras egestas in lacus a finibus. Suspendisse sed urna at elit
                                    condimentum viverra. Suspendisse non lobortis nisi. Maecenas accumsan quam quis
                                    porta laoreet. Aliquam felis odio, aliquet fermentum semper at, porttitor ac mi.
                                </li>
                                <li>
                                    <span>02.</span>
                                    Donec sit amet enim tortor. Sed egestas nulla nibh, vitae porta velit sagittis eget.
                                    Donec vitae tellus semper, cursus sem id, iaculis purus. Aenean ligula risus,
                                    maximus tristique eros vel, auctor ornare tortor. Aliquam vel augue sapien. Duis non
                                    auctor ante, ac vestibulum tortor. Etiam quis dolor ultricies, dignissim ante a,
                                    ornare ipsum. Phasellus suscipit rhoncus nulla, quis bibendum tortor elementum ac.
                                    Nullam viverra tellus diam, nec accumsan orci aliquam sed. Sed placerat sagittis
                                    lacus, non rutrum diam volutpat id.
                                </li>
                                <li>
                                    <span>03.</span>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                                    incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet. Donec in
                                    sodales dui, a blandit nunc. Pellentesque id eros venenatis, sollicitudin neque
                                    sodales, vehicula nibh. Nam massa odio, porttitor vitae efficitur non, ultricies
                                    volutpat tellus. Cras egestas in lacus a finibus. Suspendisse sed urna at elit
                                    condimentum viverra. Suspendisse non lobortis nisi. Maecenas accumsan quam quis
                                    porta laoreet. Aliquam felis odio, aliquet fermentum semper at, porttitor ac mi.
                                </li>
                                <li>
                                    <span>04.</span>
                                    Donec sit amet enim tortor. Sed egestas nulla nibh, vitae porta velit sagittis eget.
                                    Donec vitae tellus semper, cursus sem id, iaculis purus. Aenean ligula risus,
                                    maximus tristique eros vel, auctor ornare tortor. Aliquam vel augue sapien. Duis non
                                    auctor ante, ac vestibulum tortor. Etiam quis dolor ultricies, dignissim ante a,
                                    ornare ipsum. Phasellus suscipit rhoncus nulla, quis bibendum tortor elementum ac.
                                    Nullam viverra tellus diam, nec accumsan orci aliquam sed. Sed placerat sagittis
                                    lacus, non rutrum diam volutpat id.
                                </li>
                            </ul>
                        </div>
                        <div class="notes">
                            <h3>Notes</h3>
                            <div class="notes-item">
                                <span>i</span>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                                    incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet. Donec in
                                    sodales dui, a blandit nunc. Pellentesque id eros venenatis, sollicitudin neque
                                    sodales, vehicula nibh. Nam massa odio, porttitor vitae efficitur non, ultricies
                                    volutpat tellus. Cras egestas in lacus a finibus. Suspendisse sed urna at elit
                                    condimentum viverra.
                                </p>
                            </div>
                            <div class="notes-item">
                                <span>i</span>
                                <p>
                                    Donec in sodales dui, a blandit nunc. Pellentesque id eros venenatis, sollicitudin
                                    neque sodales, vehicula nibh. Nam massa odio, porttitor vitae efficitur non,
                                    ultricies volutpat tellus. Cras egestas in lacus a finibus. Suspendisse sed urna at
                                    elit condimentum viverra.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Single Recipe Section End -->

    <!-- Similar Recipe Section Begin -->
    <section class="similar-recipe spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#">
                            <img src="img/cat-feature/small-7.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Italian Tiramisu with Coffe</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#">
                            <img src="img/cat-feature/small-6.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Dry Cookies with Corn</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#">
                            <img src="img/cat-feature/small-5.jpg" alt=""></a>
                        <div class="similar-text">
                            <div class="cat-name">Vegan</div>
                            <h6>Asparagus with Pork Loin and Vegetables</h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="similar-item">
                        <a href="#">
                            <img src="img/cat-feature/small-4.jpg" alt=""></a>
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
