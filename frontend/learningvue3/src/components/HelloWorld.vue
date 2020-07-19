<template>
  <div class="demo" :title="titleMessage">
    <span v-if="showMessage">
      {{ msg }}
    </span><br>
    <label> Show Message
    <input type="checkbox" v-model="showMessage">
  </label>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data() {
    return {
      count: 0,
      titleMessage: 'You loaded this page on ' + new Date().toLocaleString(),
      showMessage: true
    }
  },
  methods: {
    add2() {
      this.count+=2;
    }
  }
}
</script>

<style scoped>
.demo {
  font-family: sans-serif;
  border: 1px solid #eee;
  border-radius: 2px;
  padding: 20px 30px;
}
</style>