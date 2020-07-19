# Using Vue3 and Vite
Both Vue and Vite have release canidates released. With this, it is very easy to get started using them, and Vite comes with first class support for Vue3 right out of the box.

## What is Vite
(Vite)[https://github.com/vitejs/vite] is a build tool that serves your code via native ES Modules imports during development, and then uses Rollup during Production. Because of this Vite is extremly fast.

## Vue 3 with Vite
Getting started with Vite also gets you started with Vue 3, and it is very easy to get going. The following instructions use `yarn` though you can view the (Vite)[https://github.com/vitejs/vite] readme to see how to use `NPM`.

In your terminal you just need to the run the following:
```
yarn create vite-app learning-vue-3
cd learning-vue-3
yarn
yarn dev
```

The following will create a Vue3 Application that uses Vite. You then `cd` into the applications directory and install the dependencies. Once all dependencies are installed you should now be able to serve the application. You should notice how fast the dev server spins up.

## Visual Studio Code with Vue 3
When using the Vetur plugin in Visual Studio Code, you may notice an error that talks about the template requires one root element. This is because Vue 3 allows you to have more than one root element in a template, while Vue 2 did not. At the time of writing this it seems Vetur does not yet notice the version of Vue that you are using. So to stop this error from popping up in your templates, you can update the extension setting called: `vetur.validation.template` and set it to `false`. If you close and reopen your `.vue` files, you should no longer see the error.