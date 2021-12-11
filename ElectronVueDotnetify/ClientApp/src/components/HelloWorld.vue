<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <div>
      <h3>{{ Greetings }}</h3>
      <p>Server time is: {{ ServerTime }}</p>
      <button class="btn btn-secondary" type="button" @click="onButtonClick">Click me</button>
      <span style="margin-left: 2rem">
            You clicked me
            <b>{{ ClickCount }}</b> times!
      </span>
    </div>
  </div>
</template>

<script>
import { defineComponent } from 'vue';
import dotnetify from 'dotnetify/vue';

export default defineComponent({
  name: 'HelloWorld',
  data() {
    return {
      msg: "tes dotnetify",
      Greetings: String,
      ServerTime: '',
      ClickCount: Number
    }
  },
  // props: {
  //   msg: String,
  // },
  created() {
    this.vm = dotnetify.vue.connect("HelloWorldVM", this, { watch: [] });
  },
  unmounted() {
    this.vm.$destroy();
  },
  methods : {
    onButtonClick() {
      this.vm.$dispatch({ ButtonClicked: true });
    }
  }
});
</script>

