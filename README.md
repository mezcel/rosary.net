We can use CSS to style the Markdown output to create a two column layout when readers view our page on a larger screen.

The main section and subsection headings both take up the entire width of the page.

article .begin-examples ~ h2,
article .begin-examples ~ h2 + p {
    width: 100%;
    clear: both;
}
Each column element is 50% width

article .begin-examples ~ h3,
article .begin-examples ~ p,
article .begin-examples ~ .highlight {
    width: 50%;
}
The left column has the main point and explanation text (h3 and p).

We'll add some padding here too for good measure.

article .begin-examples ~ h3,
article .begin-examples ~ p {
    float: left;
    box-sizing: border-box;
    padding-right: 1rem;
    clear: both;
}
While the right column has only the code examples .highlight.

And some spacing between the sections.

article .begin-examples ~ .highlight {
    float: right;
    clear: right;
    margin-bottom: 1rem;
}
That's it!

But we have to ensure that nothing goes past the end of content.

.end-examples {
    clear: both;
}
But we should clean up after ourselves.

Reset the styles to stop the two column layout. This must come after all the other styles in the CSS file.

article .end-examples ~ p,
article .end-examples ~ h3,
article .end-examples ~ .highlight {
    width: auto;
    float: none;
    clear: none;
}
Style For Small Screens

Using a media query on screens less that 580px in width, we'll create a single column layout again.

All you have to do is reset the styling on the main elements of the two column layout

article .begin-examples ~ h3,
article .begin-examples ~ p,
article .begin-examples ~ .highlight {
    width: 100%;
    float: none;
    clear: none;
}
