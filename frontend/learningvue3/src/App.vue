<template>
  <img alt="Vue logo" src="./assets/logo.png" /><br>
  <input v-model="message" class="text-input" type="text"/>
  <HelloWorld :msg="message" />
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'App',
  components: {
    HelloWorld
  },
  data() {
    return {
      message: 'Hello from Vue 3.0 + Vite'
    }
  }
}
</script>

<style scoped>
.text-input {
  padding: 4px;
  width: 30%;
  margin-bottom: 10px;
}
</style>
