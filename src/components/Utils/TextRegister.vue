<template>
  <div class="input-box">
    <i v-bind:class="icon"></i>
    <input :type="type" :placeholder="placeholder" required />
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "TextRegister",
  props: {
    type: {type: String, default: "text"},
    icon: {type: String, default: "text"},
    placeholder: {type: String, default: "text"}
  },
});
</script>

<style scoped></style>
