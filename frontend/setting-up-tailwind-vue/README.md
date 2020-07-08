# Setting up Tailwind with Vue CLI
This example and demo walks through how to setup ands tart using Tailwind with Vue CLI. 

This example created a Vue Project with just javascript support using the basic settings for the Vue CLI, and uses yarn as the package manager.

## Getting Started
The first thing to do after creating your Vue Project is to install Tailwind in the project.
* `yarn add tailwindcss`

After installing tailwindcss to the project you will want to add a couple of files to the root of the project. These files will help you configure Tailwind.

* Create a `postcss.config.js` file
The `postcss.config.js` file needs the following contents:
```js
module.exports = {
    plugins: [
        require('tailwindcss'),
        require('autoprefixer')
    ]
};
```

* Create an empty `tailwind.config.js` file using `npx tailwindcss init`
This will create the empty tailwind config file that you can then use config your tailwind installation.

Next thing you will need is a tailwind.css file. In this example it is located in: `/src/assets/styles/tailwind.css`
* Create the `tailwind.css` file
```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

After all this is complete you will need to import the css file at the bottom of the `App.vue` file
```vue
<template>
...
</template>

<script>
</script>

<style src="./assets/styles/tailwind.css">
```

## Setting Up VS Code Linting
When using tailwind with VS Code you will notice some linting warnings in the `tailwind.css`  that look similar to:  
`Unknown at rule @tailwind`

We will need use custom linting for VSCode to solve this.

### Step 1: Install the `stylelint` vscode extension
In the Visual Studio Code extensions control panel, add install the `stylelint` extension.

### Step 2: Add a stylelint.config.js to your project with this content.
To the root of your project add the `stylelint.config.js` file, with the following content:
```js
module.exports = {
    extends: ['stylelint-config-recommended'],
    rules: {
        "at-rule-no-unknown": [
          true,
          {
            ignoreAtRules: [
              "tailwind",
              "apply",
              "variants",
              "responsive",
              "screen",
            ],
          },
        ],
        "declaration-block-trailing-semicolon": null,
        "no-descending-specificity": null,
    }
}
```

you will also want to add the stylelint recommended config in the project: 
`yarn add stylelint-config-recommended --dev`

### Step 3: Disable VSCode default CSS Linting
You will need to open up the VSCode Settings window then search for `css validate`. 
You will see a setting called "CSS Validate". This setting needs to be turned off. For this example the setting gets turned off for the workspace so other projects can still use VSCodes CSS Linting. So the `settings.json` looks like:
```json
{
    "css.validate": false
}
``` 
---

## Completion
Your project should now be fully setup to use TailwindCSS. 

