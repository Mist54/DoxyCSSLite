DoxygenLite Custom CSS for Doxygen Documentation
--------------------------------------------------
This repository contains a custom CSS file (DoxygenLite.css) designed to enhance the appearance and usability of Doxygen-generated documentation.

Features of DoxygenLite.css

Modern Design: Adds a clean, responsive, and visually appealing design to your Doxygen documentation.
Enhanced Readability: Improved typography, spacing, and layout for better document readability.
Interactive Elements: Styles for navigation, code blocks, tables, and headings ensure an engaging user experience.
Responsive Design: Ensures that the documentation is fully responsive and works seamlessly on various screen sizes, including mobile devices.
Installation and Usage
Download the CSS File:

Clone this repository or download the DoxygenLite.css file directly.
Integrate with Your Doxygen Project:

Place the DoxygenLite.css file in the directory where your Doxygen HTML files are generated.
Open your Doxygen configuration file (Doxyfile) and update the following setting:
text

HTML_EXTRA_STYLESHEET = DoxygenLite.css
Generate Documentation:

Run the Doxygen command to generate your HTML documentation:
bash

doxygen Doxyfile
View Documentation:

Open the index.html file from the generated documentation folder in a web browser.
Advantages
Improved Aesthetics: Provides a professional and polished look to your documentation.
Ease of Customization: The use of CSS variables (:root) allows for quick and straightforward color and style adjustments.
Enhanced Code Presentation: Styles for code and pre elements improve the visual hierarchy and readability of code snippets.
Keyboard and Accessibility Features: Focus styles and smooth scrolling ensure accessibility for all users.
Mobile-First Design: Documentation is fully responsive and adapts gracefully to smaller screens.
Disadvantages
Browser Compatibility: Although modern browsers support CSS variables and advanced features, older browsers may not fully render the styles as intended.
Manual Integration: Requires additional steps to integrate with Doxygen, especially for beginners unfamiliar with custom configurations.
Learning Curve for Customization: Adjusting the variables or styles might need basic CSS knowledge.
Customization
Variables for Quick Customization
The CSS file includes a set of variables that you can modify for quick customization:

css

:root {
    --primary-color: #0d6efd;
    --secondary-color: #6c757d;
    --success-color: #198754;
    --info-color: #0dcaf0;
    --warning-color: #ffc107;
    --danger-color: #dc3545;
    --light-bg: #ffffff;
    --text-color: #212529;
    --border-radius: 0.375rem;
    --box-shadow: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075);
    --transition: all 0.2s ease-in-out;
}
Change --primary-color to customize the primary accent color.
Adjust --text-color and --light-bg for dark mode or custom themes.
Advanced Customization
Feel free to tweak other classes and elements in the CSS file for specific requirements (e.g., modify navigation or table styles).

Troubleshooting
Styles Not Applying:

Ensure that the HTML_EXTRA_STYLESHEET path in Doxyfile correctly points to DoxygenLite.css.
Responsive Design Issues:

Verify that you are viewing the documentation in a modern browser that supports CSS flexbox and media queries.
Accessibility Issues:

Test keyboard navigation and focus styles across multiple browsers to ensure consistent behavior.
Contribution
If you find any issues or have suggestions for improvement, feel free to fork this repository, make your changes, and submit a pull request.