<template>
  <div class="input-boxes">
    <div class="input-box">
      <i v-bind:class="icon"></i>
      <input type="text" :placeholder="placeholder" required />
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "TextRegister",
  props: ["icon", "placeholder"],
});
</script>

<style scoped></style>
